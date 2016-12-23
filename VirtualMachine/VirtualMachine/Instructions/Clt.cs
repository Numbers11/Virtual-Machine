﻿using NeuroSystem.VirtualMachine.Instrukcje;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroSystem.VirtualMachine.Instrukcje
{
    //Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
    public class Clt : InstrukcjaBazowa
    {
        public Clt(Instruction instrukcja) : base(instrukcja)
        {
        }

        public override void Wykonaj()
        {
            dynamic b = Pop();
            dynamic a = Pop();

            dynamic wynik = a < b ? 1 : 0;
            Push(wynik);
            WykonajNastepnaInstrukcje();
        }
    }
}