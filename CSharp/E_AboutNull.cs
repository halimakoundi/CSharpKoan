using NUnit.Framework;

namespace DotNetKoans.CSharp
{
    public class E_AboutNull : Koan
    {
        [Koan(1)]
        public void A_NullIsNotAnObject()
        {
            Assert.True(typeof(object).IsAssignableFrom(null)); //not everything is an object
        }

        [Koan(2)]
        public void B_YouGetNullPointerErrorsWhenCallingMethodsOnNull()
        {
            //What is the Exception that is thrown when you call a method on a null object?
            //Don't be confused by the code below. It is using Anonymous Delegates which we will
            //cover later on. 
            object nothing = null;
            Assert.Throws(typeof(FillMeIn), delegate() { nothing.ToString(); });

            //What's the message of the exception? What substring or pattern could you test
            //against in order to have a good idea of what the string is?
            try
            {
                nothing.ToString();
            }
            catch (System.Exception ex)
            {
				Assert.IsTrue(ex.Message.Contains(FILL_ME_IN as string));
            }
        }

        [Koan(3)]
        public void C_CheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj == FILL_ME_IN);
        }

#pragma warning disable 219
//this prevents from showing a warning message that says that the variable is never used
        [Koan(4)]
        public void D_ABetterWayToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.Null(FILL_ME_IN);
        }

        [Koan(5)]
        public void E_AWayNotToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj.Equals(null));
        }
    }
}
