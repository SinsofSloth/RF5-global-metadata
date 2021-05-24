internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

internal class CADMessageBase // TypeDefIndex: 1200
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x174D0D0 Offset: 0x174D1D1 VA: 0x174D0D0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x174D4B0 Offset: 0x174D5B1 VA: 0x174D4B0
	internal MethodBase GetMethod() { }

	// RVA: 0x174D960 Offset: 0x174DA61 VA: 0x174D960
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x174DB90 Offset: 0x174DC91 VA: 0x174DB90
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x174E610 Offset: 0x174E711 VA: 0x174E610
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x174E7A0 Offset: 0x174E8A1 VA: 0x174E7A0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x174E950 Offset: 0x174EA51 VA: 0x174E950
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x174EBA0 Offset: 0x174ECA1 VA: 0x174EBA0
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x174F210 Offset: 0x174F311 VA: 0x174F210
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x174F340 Offset: 0x174F441 VA: 0x174F340
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x174F470 Offset: 0x174F571 VA: 0x174F470
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x174F7C0 Offset: 0x174F8C1 VA: 0x174F7C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

