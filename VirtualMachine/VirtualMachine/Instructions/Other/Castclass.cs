﻿using Mono.Reflection;

namespace NeuroSystem.VirtualMachine.Instructions.Other
{
    public class Castclass : InstructionBase
    {
        public Castclass(Instruction instrukcja) : base(instrukcja)
        {
        }

        public override void Wykonaj()
        {
            WykonajNastepnaInstrukcje();
        }
    }
}