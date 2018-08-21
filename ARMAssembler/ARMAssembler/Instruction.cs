using System;
using System.Collections.Generic;
using System.Text;

namespace ARMAssembler
{
    public enum Operation
    {
        MOVW,
        MOVT,
        OR,
        ADD,
        SUB,
        CMP,
        STR,
        LDR,
        BNE,
        B,
        NONE
    }

    public enum Register
    {
        R1,
        R2,
        R3,
        R4,
        R5,
        R6,
        R7,
        R8,
        R9,
        R10,
        R11,
        R12
    }

    public class Instruction
    {
        public Operation Operation { get; set; }
        public Register? SourceRegister { get; set; }
        public Register? DestinationRegister { get; set; }
        public byte?[] ImmediateValue { get; set; }

        public Instruction(Operation op, Register? src, Register? dest, byte?[] immVal)
        {
            Operation = op;
            SourceRegister = src;
            DestinationRegister = dest;
            ImmediateValue = immVal;
        }

        public static Instruction Convert(Token[] tokens)
        {
            //foreach (Token t in tokens)
            //{
                //Logic?
                Operation op = Operation.NONE;
                Register src = Register.R1;
                Register dest = Register.R2;
                byte?[] immVal = null;
            //}
            return new Instruction(op, src, dest, immVal);
        }

        public static Operation ToOperation(Token token)
        {
            return Enum.Parse<Operation>(token.Value);
        }

        public static Register ToRegister(Token token)
        {
            return Enum.Parse<Register>(token.Value);
        }
    }
}
