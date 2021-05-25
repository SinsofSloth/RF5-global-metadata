[ExtensionAttribute] // RVA: 0x139360 Offset: 0x139461 VA: 0x139360
internal static class ILGeneratorExtensions // TypeDefIndex: 5295
{
	// Methods

	[ExtensionAttribute] // RVA: 0x13A720 Offset: 0x13A821 VA: 0x13A720
	// RVA: 0x167FCB0 Offset: 0x167FDB1 VA: 0x167FCB0
	public static void EmitLdloc(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A730 Offset: 0x13A831 VA: 0x13A730
	// RVA: 0x1676AA0 Offset: 0x1676BA1 VA: 0x1676AA0
	public static void EmitLdloc(ILGenerator il, LocalBuilder local) { }

	[ExtensionAttribute] // RVA: 0x13A740 Offset: 0x13A841 VA: 0x13A740
	// RVA: 0x167FE80 Offset: 0x167FF81 VA: 0x167FE80
	public static void EmitStloc(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A750 Offset: 0x13A851 VA: 0x13A750
	// RVA: 0x1676A60 Offset: 0x1676B61 VA: 0x1676A60
	public static void EmitStloc(ILGenerator il, LocalBuilder local) { }

	[ExtensionAttribute] // RVA: 0x13A760 Offset: 0x13A861 VA: 0x13A760
	// RVA: 0x1680050 Offset: 0x1680151 VA: 0x1680050
	public static void EmitLdloca(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A770 Offset: 0x13A871 VA: 0x13A770
	// RVA: 0x16782E0 Offset: 0x16783E1 VA: 0x16782E0
	public static void EmitLdloca(ILGenerator il, LocalBuilder local) { }

	[ExtensionAttribute] // RVA: 0x13A780 Offset: 0x13A881 VA: 0x13A780
	// RVA: 0x16769E0 Offset: 0x1676AE1 VA: 0x16769E0
	public static void EmitTrue(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A790 Offset: 0x13A891 VA: 0x13A790
	// RVA: 0x1680220 Offset: 0x1680321 VA: 0x1680220
	public static void EmitFalse(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A7A0 Offset: 0x13A8A1 VA: 0x13A7A0
	// RVA: 0x1680120 Offset: 0x1680221 VA: 0x1680120
	public static void EmitBoolean(ILGenerator il, bool value) { }

	[ExtensionAttribute] // RVA: 0x13A7B0 Offset: 0x13A8B1 VA: 0x13A7B0
	// RVA: 0x16765D0 Offset: 0x16766D1 VA: 0x16765D0
	public static void EmitLdc_I4(ILGenerator il, int value) { }

	[ExtensionAttribute] // RVA: 0x13A7C0 Offset: 0x13A8C1 VA: 0x13A7C0
	// RVA: 0x16802A0 Offset: 0x16803A1 VA: 0x16802A0
	public static void EmitUnboxOrCast(ILGenerator il, Type type) { }

	[ExtensionAttribute] // RVA: 0x13A7D0 Offset: 0x13A8D1 VA: 0x13A7D0
	// RVA: 0x1676AE0 Offset: 0x1676BE1 VA: 0x1676AE0
	public static void EmitBoxOrDoNothing(ILGenerator il, Type type) { }

	[ExtensionAttribute] // RVA: 0x13A7E0 Offset: 0x13A8E1 VA: 0x13A7E0
	// RVA: 0x167A890 Offset: 0x167A991 VA: 0x167A890
	public static void EmitLdarg(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A7F0 Offset: 0x13A8F1 VA: 0x13A7F0
	// RVA: 0x16731E0 Offset: 0x16732E1 VA: 0x16731E0
	public static void EmitLoadThis(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A800 Offset: 0x13A901 VA: 0x13A800
	// RVA: 0x1680380 Offset: 0x1680481 VA: 0x1680380
	public static void EmitLdarga(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A810 Offset: 0x13A911 VA: 0x13A810
	// RVA: 0x1680450 Offset: 0x1680551 VA: 0x1680450
	public static void EmitStarg(ILGenerator il, int index) { }

	[ExtensionAttribute] // RVA: 0x13A820 Offset: 0x13A921 VA: 0x13A820
	// RVA: 0x1680520 Offset: 0x1680621 VA: 0x1680520
	public static void EmitPop(ILGenerator il, int count) { }

	[ExtensionAttribute] // RVA: 0x13A830 Offset: 0x13A931 VA: 0x13A830
	// RVA: 0x16768F0 Offset: 0x16769F1 VA: 0x16768F0
	public static void EmitCall(ILGenerator il, MethodInfo methodInfo) { }

	[ExtensionAttribute] // RVA: 0x13A840 Offset: 0x13A941 VA: 0x13A840
	// RVA: 0x167A350 Offset: 0x167A451 VA: 0x167A350
	public static void EmitLdfld(ILGenerator il, FieldInfo fieldInfo) { }

	[ExtensionAttribute] // RVA: 0x13A850 Offset: 0x13A951 VA: 0x13A850
	// RVA: 0x16805E0 Offset: 0x16806E1 VA: 0x16805E0
	public static void EmitLdsfld(ILGenerator il, FieldInfo fieldInfo) { }

	[ExtensionAttribute] // RVA: 0x13A860 Offset: 0x13A961 VA: 0x13A860
	// RVA: 0x1680680 Offset: 0x1680781 VA: 0x1680680
	public static void EmitRet(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A870 Offset: 0x13A971 VA: 0x13A870
	// RVA: 0x1680700 Offset: 0x1680801 VA: 0x1680700
	public static void EmitIntZeroReturn(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A880 Offset: 0x13A981 VA: 0x13A880
	// RVA: 0x16807E0 Offset: 0x16808E1 VA: 0x16807E0
	public static void EmitNullReturn(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A890 Offset: 0x13A991 VA: 0x13A890
	// RVA: 0x1680880 Offset: 0x1680981 VA: 0x1680880
	public static void EmitULong(ILGenerator il, ulong value) { }

	[ExtensionAttribute] // RVA: 0x13A8A0 Offset: 0x13A9A1 VA: 0x13A8A0
	// RVA: 0x1680910 Offset: 0x1680A11 VA: 0x1680910
	public static void EmitThrowNotimplemented(ILGenerator il) { }

	[ExtensionAttribute] // RVA: 0x13A8B0 Offset: 0x13A9B1 VA: 0x13A8B0
	// RVA: 0x16775A0 Offset: 0x16776A1 VA: 0x16775A0
	public static void EmitIncrementFor(ILGenerator il, LocalBuilder conditionGreater, Action<LocalBuilder> emitBody) { }
}

