﻿using System;
using NUnit.Framework;

namespace DotNetKoans.CSharp
{
    public class D_AboutProperties : Koan
    {
        class ClassWithGet
        {
            public ClassWithGet()
            {
                a = 1;
            }
            private int a;
            public int A
            {
                get { return a; }
            }
        }
        [Koan(1)]
        public void A_ClassesCanHaveGetters()
        {
            // Classes can can have properties with just a getter.
            ClassWithGet obj = new ClassWithGet();

            // This class only has a get for A, so this would be illegal:
            //obj.A = 5;
            Assert.AreEqual(FILL_ME_IN, obj.A);
        }

        class ClassWithGetSet
        {
            public ClassWithGetSet()
            {
                a = 1;
            }
            private int a;
            public int A
            {
                get { return a; }
                set { a = value; }
            }
        }
        [Koan(2)]
        public void B_ClassesCanHaveGettersAndSetters()
        {
            // Classes can can have properties with both getters and setters.
            ClassWithGetSet obj = new ClassWithGetSet();

            // This class has a get and set for A, so you can do this:
            obj.A = 5;
            Assert.AreEqual(FILL_ME_IN, obj.A);
        }

        class ClassWithDefaultGetSet
        {
            public ClassWithDefaultGetSet()
            {
                A = 2;
            }
            public int A
            {
                get;
                set;
            }
        }
        [Koan(3)]
        public void C_ClassesCanHaveDefaultGettersAndSetters()
        {
            // Classes can also have properties with default getters and setters,
            // where you don't need to supply a body if they just set and return a field
            // you neither have to declare a field for it.
            ClassWithDefaultGetSet obj = new ClassWithDefaultGetSet();

            obj.A = 5;
            Assert.AreEqual(FILL_ME_IN, obj.A);
        }

        class ClassWithPublicGetAndPrivateSet
        {
            public ClassWithPublicGetAndPrivateSet()
            {
                Side = 0;
                Area = 0;
            }
            private int side;
            public int Side
            {
                get
                {
                    return side;
                }
                set
                {
                    side = value;
                    Area = side * side;
                }
            }
            public int Area
            {
                get;
                private set;
            }
        }
        [Koan(4)]
        public void D_ClassesCanHavePublicGettersWithPrivateSetters()
        {
            // It is possible to have a property with a public getter and a private setter,
            // so a user of the class can get the value but not set it, although methods of
            // the class can set it.
            // The property declaration has to be public, while the setter is declared private.
            ClassWithPublicGetAndPrivateSet obj = new ClassWithPublicGetAndPrivateSet();

            // So this would be illegal:
            // obj.Area = 20;

            obj.Side = 5;
            Assert.AreEqual(FILL_ME_IN, obj.Side);
            Assert.AreEqual(FILL_ME_IN, obj.Area);
        }

        class ClassWithIndexer
        {
            private int[] arr;
            public ClassWithIndexer()
            {
                arr = new[] { 1, 2, 3 };
            }
            public int this[long index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }

        [Koan(5)]
        public void E_ClassesCanHaveIndexers()
        {
            // An indexer allows a class to act as an array.
            ClassWithIndexer obj = new ClassWithIndexer();

            obj[0] = 5;
            obj[1] = 7;
            Assert.AreEqual(FILL_ME_IN, obj[0]);
            Assert.AreEqual(FILL_ME_IN, obj[1]);
        }
    }
}
