.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
  .ver 2:0:0:0
}

.assembly CaIFaceImpl {}

.module CaIFaceImpl.dll

.class private FooAttribute
	extends [mscorlib]System.Attribute
{
	.method public specialname rtspecialname instance void .ctor () cil managed
	{
		ldarg.0
		call instance void [mscorlib]System.Attribute::.ctor ()
		ret
	}
}

.class interface private abstract auto ansi IFoo
{
}

.class interface private abstract auto ansi FooClass
       implements IFoo
{
	.interfaceimpl type IFoo
	.custom instance void FooAttribute::.ctor()
}
