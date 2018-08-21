using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ARMAssembler
{
    //this class will turn instructions from tokens into machine code.
    //always run: 1110

    public class Translator
    {
        //4 values in every byte array: byte = 8 bit, 32bit instructions, 4*8 = 32
        public byte[] Translate(Instruction instruction)
        {
            byte[] machine = GetMachineBytes(instruction);
            return null;
        }

        private byte[] GetMachineBytes(Instruction inst)
        {
            byte[] machineInst = new byte[4];
            switch (inst.Operation)
            {
                case Operation.MOVW:
                    machineInst[0] = 0b1110_0011; //opcode: always run, and operation
                    machineInst[1] = 0b0100; //need to add immediate value top
                    machineInst[2] = 0b0; //destination register & 4 bits of lower
                    machineInst[3] = 0b0; // last 12 bis of lower
                    break;
                case Operation.MOVT:
                    break;
                case Operation.OR:
                    break;
                case Operation.ADD:
                    break;
                case Operation.SUB:
                    break;
                case Operation.CMP:
                    break;
                case Operation.STR:
                    break;
                case Operation.LDR:
                    break;
                case Operation.BNE:
                    break;
                case Operation.B:
                    break;
                case Operation.NONE:
                    break;
            }
            return null;
        }
    }
}
