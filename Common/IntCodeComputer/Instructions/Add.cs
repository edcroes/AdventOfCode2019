﻿using System;

namespace AoC2019.Common.IntCodeComputer.Instructions
{
    public struct Add : IInstruction
    {
        public int Opcode => 1;

        public int Length => 4;

        public void Execute(IntCodeComputer computer, int[] parameters)
        {
            var left = computer.GetMemory(parameters[0]);
            var right = computer.GetMemory(parameters[1]);
            var result = left + right;
            computer.SetMemory(parameters[2], result);
        }
    }
}