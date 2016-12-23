﻿using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroSystem.VirtualMachine.Instrukcje
{
    public class Sub : InstrukcjaBazowa
    {
        public Sub(Instruction instrukcja) : base(instrukcja)
        {
        }

        public override void Wykonaj()
        {
            dynamic b = Pop();
            dynamic a = Pop();
            
            dynamic wynik = a - b;
            Push(wynik);
            WykonajNastepnaInstrukcje();
        }
    }
}