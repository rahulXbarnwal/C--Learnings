using System;

/*
 A partial class or struct can contain partial methods
 A partial method declaration consists of two parts. These may be in separate part of partial class, or in the same part 
 1) The definition (only the method signature)
 2) The implementation
 
 The implementation for a partial method is optional. If we don't provide the implementation, the compiler removes the signature and all calls to the method
 Partial methods are private by default, and its compilation error to include any access modifiers, including private.
 Its compilation error to include declaration & implementation at the same time for a partial method.
 A partial method return type must be void, else compilation error.
 Sign of the partial method declaration must match with the sign of implementation.
 A non-partial class or struct can't include partial methods.
 A partial method can be implemented only once, else compilation error.
 */

namespace PartialMethodsDemo
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        //partial void SamplePartialMethod()
        //{
        //    Console.WriteLine("SamplePartialMethod Invoked");
        //}
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
