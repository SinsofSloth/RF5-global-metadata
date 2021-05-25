public class InvalidKeyException : Exception // TypeDefIndex: 5669
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13DC80 Offset: 0x13DD81 VA: 0x13DC80
	private object <Key>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x13DC90 Offset: 0x13DD91 VA: 0x13DC90
	private Type <Type>k__BackingField; // 0x90

	// Properties
	public object Key { get; set; }
	public Type Type { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13E550 Offset: 0x13E651 VA: 0x13E550
	// RVA: 0x15E9B70 Offset: 0x15E9C71 VA: 0x15E9B70
	public object get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E560 Offset: 0x13E661 VA: 0x13E560
	// RVA: 0x15E9B80 Offset: 0x15E9C81 VA: 0x15E9B80
	private void set_Key(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E570 Offset: 0x13E671 VA: 0x13E570
	// RVA: 0x15E9B90 Offset: 0x15E9C91 VA: 0x15E9B90
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E580 Offset: 0x13E681 VA: 0x13E580
	// RVA: 0x15E9BA0 Offset: 0x15E9CA1 VA: 0x15E9BA0
	private void set_Type(Type value) { }

	// RVA: 0x15E9BB0 Offset: 0x15E9CB1 VA: 0x15E9BB0
	public void .ctor(object key) { }

	// RVA: 0x15DEC10 Offset: 0x15DED11 VA: 0x15DEC10
	public void .ctor(object key, Type type) { }

	// RVA: 0x15E9CB0 Offset: 0x15E9DB1 VA: 0x15E9CB0
	public void .ctor() { }

	// RVA: 0x15E9D20 Offset: 0x15E9E21 VA: 0x15E9D20
	public void .ctor(string message) { }

	// RVA: 0x15E9DA0 Offset: 0x15E9EA1 VA: 0x15E9DA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15E9E20 Offset: 0x15E9F21 VA: 0x15E9E20
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x15E9EB0 Offset: 0x15E9FB1 VA: 0x15E9EB0 Slot: 5
	public override string get_Message() { }
}

