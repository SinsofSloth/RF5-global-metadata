internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1201
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x174F870 Offset: 0x174F971 VA: 0x174F870
	internal string get_Uri() { }

	// RVA: 0x1741070 Offset: 0x1741171 VA: 0x1741070
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x174F880 Offset: 0x174F981 VA: 0x174F880
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x174FAB0 Offset: 0x174FBB1 VA: 0x174FAB0
	internal ArrayList GetArguments() { }

	// RVA: 0x174FBA0 Offset: 0x174FCA1 VA: 0x174FBA0
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x174FBB0 Offset: 0x174FCB1 VA: 0x174FBB0
	internal int get_PropertiesCount() { }
}

