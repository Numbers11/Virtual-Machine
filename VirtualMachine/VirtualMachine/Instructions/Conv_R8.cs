﻿using Mono.Cecil.Cil;

namespace NeuroSystem.VirtualMachine.Instrukcje
{
    /// <summary>
    /// Converts the value on top of the evaluation stack to float64.
    /// </summary>
    internal class Conv_R8 : InstrukcjaBazowa
    {
        public Conv_R8(Instruction ins) : base(ins)
        {
        }       

        public override void Wykonaj()
        {
            dynamic a = Pop();

            dynamic wynik = (double)a;
            Push(wynik);            

            WykonajNastepnaInstrukcje();
        }
    }
}