﻿using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    public class WrongExpressions
    {
        /// <summary>
        /// A boolean expression using one variable.
        /// returns always a boolean value result.
        /// 
        /// The execution finish successfully.
        /// </summary>
        public static void A_Eq_12_MissingBracket()
        {
            string expr = "(A = 12";
            Console.WriteLine("\n====The expression is: " + expr);

            ExpressionEval evaluator = new ExpressionEval();

            //====1/decode the expression
            ExprParseResult parseResult = evaluator.Parse(expr);

            if(parseResult.HasError)
            {
                Console.WriteLine("The expr '" + expr + "' has errors, nb=" + parseResult.ListError.Count);
                ExprTokensParseError error = parseResult.ListError[0];
                Console.WriteLine("Error code: " + error.ErrCode);
                Console.WriteLine("Pos in the expr: " + error.Position);
                Console.WriteLine("Wrong token in the expr: " + error.Token);
                return;
            }

            Console.WriteLine("The expr " + expr + " parse finished sucessfully!" );

        }
    }
}