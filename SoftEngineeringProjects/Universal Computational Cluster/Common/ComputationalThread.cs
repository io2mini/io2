﻿using System;
using System.Threading;
using Common.Configuration;
using Common.Messages;
using UCCTaskSolver;

namespace Common
{
    /// <summary>
    ///     Klasa zawierająca parametry wątku obliczeniowego posiadanego przez Node lub TM
    /// </summary>
    public class ComputationalThread
    {
        public ulong ProblemInstanceId;
        public bool ProblemInstanceIdSpecified;
        public string ProblemType;
        public StatusThreadState State;
        public DateTime StateChange;
        public bool StateChangeSpecified;
        public ulong TaskId;
        public bool TaskIdSpecified;
        public TaskSolver TaskSolver;
        public Thread Solver;
        public ThreadInfo Localisation;
        public void StartSolving(ulong problemInstanceId, string problemType, ulong taskId, TimeSpan timeout, byte[] data)
        {
            
            ThreadStart starter = () => Solve(data, timeout);
            Solver = new Thread(starter);
            Solver.Start();
        }
        private void Solve(byte[] data, TimeSpan timeout)
        {
            SolutionCallback(TaskSolver.Solve(data, timeout));
        }
        private void SolutionCallback(byte[] data)
        {
            Solver = null;
            if (State == StatusThreadState.Idle) return;
            Localisation.SolutionCallback(data,this);
        }
        public ComputationalThread()
        {
            ProblemInstanceIdSpecified = false;
            ProblemInstanceId = 0;
            TaskIdSpecified = false;
            TaskId = 0;
            ProblemType = null;
            StateChange = DateTime.Now;
            StateChangeSpecified = false;
            Solver = null;
            TaskSolver = null;
            State = StatusThreadState.Idle;
        }

        public void SetStatus(StatusThreadState status)
        {
            // TODO: ignore callback if aborting
            if (status == StatusThreadState.Idle)
            {
                Solver.Abort();
                Solver = null;
            }
            State = status;
        }
    }
}