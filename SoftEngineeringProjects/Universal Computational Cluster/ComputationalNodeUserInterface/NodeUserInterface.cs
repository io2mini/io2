﻿using System;
using Common.Components;
using Common.Configuration;
using Common.Exceptions;
using Common.Properties;

namespace Common.UserInterface
{
    public class NodeUserInterface
    {
        private static void Main(string[] args)
        {
            var computationalNode = new ComputationalNode();
            Console.WriteLine(Resources.NodeUserInterface_Main_Computational_Node_started_successfully);
            string newLine;
            var hasData = false;
            while (computationalNode.IsWorking && !hasData)
            {
                newLine = Console.ReadLine();
                try
                {
                    computationalNode.Info = ParametersParser.ReadParameters(newLine,
                        SystemComponentType.ComputationalNode);
                    hasData = true;
                }
                catch (ParsingArgumentException)
                {
                    Console.WriteLine("Wrong Arguments");
                }
            }
            computationalNode.Start();
            while (computationalNode.IsWorking)
            {
            }
            Console.WriteLine("Computational Node ended successfully");
        }
    }
}