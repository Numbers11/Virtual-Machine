﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil.Cil;
using NeuroSystem.VirtualMachine.Core;

namespace NeuroSystem.VirtualMachine.Instructions.Storage
{
    /// <summary>
    /// Replaces the value of a static field with a value from the evaluation stack.
    /// https://msdn.microsoft.com/pl-pl/library/system.reflection.emit.opcodes.stsfld(v=vs.110).aspx
    /// </summary>
    public class Stsfld : InstructionBase
    {
        public Stsfld(Instruction instrukcja) : base(instrukcja)
        {

        }
        
        public override void Wykonaj()
        {
            var o = PopObject();

            //ustawiam statyczną zmienną wartością ze stosu
            var fieldDefinition = instrukcja.Operand as Mono.Cecil.FieldDefinition;
            var typ = fieldDefinition.DeclaringType.GetSystemType();
            var field = typ.GetField(fieldDefinition.Name);
            field.SetValue(null, o);
            
            WykonajNastepnaInstrukcje();
        }
    }
}