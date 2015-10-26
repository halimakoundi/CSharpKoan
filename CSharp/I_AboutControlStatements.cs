using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DotNetKoans.CSharp
{
    public class I_AboutControlStatements : Koan
    {
#pragma warning disable 162
        [Koan(1)]
        public void A_IfThenStatementsWithBrackets()
        {
            bool b = false;
            if (true)
            {
                b = true;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(2)]
        public void B_IfThenStatementsWithoutBrackets()
        {
            bool b = false;
            if (true)
                b = true;

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(3)]
        public void C_WhyItsWiseToAlwaysUseBrackets()
        {
            bool b1 = false;
            bool b2 = false;

            int counter = 1;

            if (counter == 0)
                b1 = true;
                b2 = true;

            Assert.AreEqual(FILL_ME_IN, b1);
            Assert.AreEqual(FILL_ME_IN, b2);
        }

        [Koan(4)]
        public void D_IfThenElseStatementsWithBrackets()
        {
            bool b;
            if (true)
            {
                b = true;
            }
            else
            {
                b = false;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(5)]
        public void E_IfThenElseStatementsWithoutBrackets()
        {
            bool b;
            if(true)
                b = true;
            else
                b = false;

            Assert.AreEqual(FILL_ME_IN, b);

        }

        [Koan(6)]
        public void F_TernaryOperators()
        {
            Assert.AreEqual(FILL_ME_IN, (true ? 1 : 0));
            Assert.AreEqual(FILL_ME_IN, (false ? 1 : 0));
        }

#pragma warning disable 219
        //This is out of place for control statements, but necessary for Koan 8
        [Koan(7)]
        public void G_NullableTypes()
        {
            int i = 0;
            //i = null; //You can't do this

            int? nullableInt = null; //but you can do this
			Assert.NotNull(FILL_ME_IN);
			Assert.Null(FILL_ME_IN);
        }

        [Koan(8)]
        public void H_AssignIfNullOperator()
        {
            int? nullableInt = null;

            int x = nullableInt ?? 42;

            Assert.AreEqual(FILL_ME_IN, x);
        }

#pragma warning disable 184
        [Koan(9)]
        public void I_IsOperators()
        {
            bool isKoan = false;
            bool isAboutControlStatements = false;
            bool isAboutMethods = false;

            var myType = this;

            if (myType is Koan)
                isKoan = true;

            if (myType is I_AboutControlStatements)
                isAboutControlStatements = true;

            if (myType is C_AboutMethods)
                isAboutMethods = true;

            Assert.AreEqual(FILL_ME_IN, isKoan);
            Assert.AreEqual(FILL_ME_IN, isAboutControlStatements);
            Assert.AreEqual(FILL_ME_IN, isAboutMethods);

        }

        [Koan(10)]
        public void J_WhileStatement()
        {
            int i = 1;
            int result = 1;
            while (i <= 3)
            {
                result = result + i;
                i += 1;
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [Koan(11)]
        public void K_BreakStatement()
        {
            int i = 1;
            int result = 1;
            while (true)
            {
                if (i > 3) { break; }
                result = result + i;
                i += 1;    
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [Koan(12)]
        public void L_ContinueStatement()
        {
            int i = 0;
            var result = new List<int>();
            while(i < 10)
            {
                i += 1;
                if ((i % 2) == 0) { continue; }
                result.Add(i);
            }
            Assert.AreEqual(FILL_ME_IN, result);
        }

        [Koan(13)]
        public void M_ForStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = (list[i].ToUpper());
            }
            Assert.AreEqual(FILL_ME_IN, list);
        }

        [Koan(14)]
        public void N_ForEachStatement()
        {
            var list = new List<string> { "fish", "and", "chips" };
            var finalList = new List<string>();
            foreach (string item in list)
            {
                finalList.Add(item.ToUpper());
            }
            Assert.AreEqual(FILL_ME_IN, list);
            Assert.AreEqual(FILL_ME_IN, finalList);
        }

        [Koan(15)]
        public void O_ModifyingACollectionDuringForEach()
        {
            var list = new List<string> { "fish", "and", "chips" };
            try
            {
                foreach (string item in list)
                {
                    list.Add(item.ToUpper());
                }
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(FillMeIn), ex.GetType());
            }
        }

        [Koan(16)]
        public void P_CatchingModificationExceptions()
        {
            string whoCaughtTheException = "No one";

            var list = new List<string> { "fish", "and", "chips" };
            try
            {
                foreach (string item in list)
                {
                    try
                    {
                        list.Add(item.ToUpper());
                    }
                    catch
                    {
                        whoCaughtTheException = "When we tried to Add it";
                    }
                }
            }
            catch
            {
                whoCaughtTheException = "When we tried to move to the next item in the list";
            }

            Assert.AreEqual(FILL_ME_IN, whoCaughtTheException);
        }

        [Koan(17)]
        public void Q_Switch()
        {
            // A switch statement allows you to execute one of several blocks of code
            // depending on the value of an integer, give after the case keyword.
            // Each block ends with break (but we'll see an alternative soon).

            int a = 2, b = 0;
            switch (a)
            {
                case 1:
                    b = 10;
                    break;
                case 2:
                    b = 11;
                    break;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(18)]
        public void R_SwitchWithFallThrough()
        {
            // A block can handle multiple values of the variable,
            // by grouping the case statements.
            // In this case there can be no code between the case statements.

            int a = 1, b = 0;
            switch (a)
            {
                case 1:
                case 2:
                    b = 11;
                    break;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(19)]
        public void S_SwitchWithDefault()
        {
            // If the value is not matched, the code after the default keyword
            // is executed, if there is one.
            int a = 3, b = 0;
            switch (a)
            {
                case 1:
                    b = 10;
                    break;
                case 2:
                    b = 11;
                    break;
                default:
                    b = 12;
                    break;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(20)]
        public void T_SwitchWithGoto()
        {
            // Instead of break you can end a block in a switch block with any statement
            // that ends the block, like return or throw.
            // In this case we use another one, goto case.
            // This makes it continue in another block.

            int a = 2, b = 0;
            switch (a)
            {
                case 1:
                    b = 10;
                    break;
                case 2:
                    b = 11;
                    goto case 1;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        [Koan(21)]
        public void U_SwitchWithStrings()
        {
            // Instead of integers you can also use strings.
            string a = "a";
            int b = 0;
            switch (a)
            {
                case "a":
                    b = 10;
                    break;
                case "b":
                    b = 11;
                    break;
            }

            Assert.AreEqual(FILL_ME_IN, b);
        }

        // The yield keyword makes a function act as an iterator.
        // This creates an interesting control flow.
        // Every time 'yield return' is encountered, the control goes back
        // to the calling function. When the next element is requested,
        // control goes back to the function right after the 'yield return'.
        // All variables still have their values, because it runs on a separate stack.

        private static System.Collections.Generic.IEnumerable<int> Fibonacci1(int n)
        {
            int f1 = 0, f2 = 1;
            for (int i = 0; i < n; ++i)
            {
                int f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                yield return f1;
            }
        }

        [Koan(22)]
        public void V_Yield()
        {
            var fibonacci = new List<int>();
            foreach (int f in Fibonacci1(5))
            {
                fibonacci.Add(f);
            }
            Assert.AreEqual(new List<int>() { }, fibonacci);
        }

        // yield break allows you to stop the iteration
        private static System.Collections.Generic.IEnumerable<int> Fibonacci2(int n)
        {
            int f1 = 0, f2 = 1;
            int i = 0;
            while (true)
            {
                int f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                yield return f1;

                ++i;
                if (i == n)
                    yield break;
            }
        }

        [Koan(23)]
        public void W_YieldWithBreak()
        {
            var fibonacci = new List<int>();
            foreach (int f in Fibonacci2(5))
            {
                fibonacci.Add(f);
            }
            Assert.AreEqual(new List<int>() { }, fibonacci);
        }
    }
}