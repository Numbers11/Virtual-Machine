﻿using Mono.Cecil.Cil;

namespace NeuroSystem.VirtualMachine.Instrukcje
{
    /// <summary>
    /// Załaduj adres argumentu w krótkiej forme na stos.
    /// </summary>
    internal class Ldarga : InstrukcjaBazowa
    {
        private int index;

        public Ldarga(Instruction instrukcja) : base(instrukcja)
        {
            index = ((Mono.Cecil.ParameterDefinition) instrukcja.Operand).Index;
            if (((Mono.Cecil.ParameterDefinition) instrukcja.Operand).Method.HasThis)
            {
                index++;
            }
            
            this.instrukcja = instrukcja;
        }

        public override void Wykonaj()
        {
            var o = PobierzAdresArgumentu(index);
            Push(o);
            WykonajNastepnaInstrukcje();
        }

        public override string ToString()
        {
            return "Ldarga " + index;
        }
    }
}