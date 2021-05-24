[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

[ComVisibleAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ClassInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[ComDefaultInterfaceAttribute] // RVA: 0xAE620 Offset: 0xAE721 VA: 0xAE620
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 609
{
	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17EF070 Offset: 0x17EF171 VA: 0x17EF070
	protected void .ctor() { }

	// RVA: 0x17EF080 Offset: 0x17EF181 VA: 0x17EF080 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EF260 Offset: 0x17EF361 VA: 0x17EF260
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EF4F0 Offset: 0x17EF5F1 VA: 0x17EF4F0 Slot: 7
	public virtual Type get_ParameterType() { }

	// RVA: 0x17EF500 Offset: 0x17EF601 VA: 0x17EF500 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17EF510 Offset: 0x17EF611 VA: 0x17EF510
	public bool get_IsIn() { }

	// RVA: 0x17EF530 Offset: 0x17EF631 VA: 0x17EF530
	public bool get_IsOptional() { }

	// RVA: 0x17EF550 Offset: 0x17EF651 VA: 0x17EF550
	public bool get_IsOut() { }

	// RVA: 0x17EF240 Offset: 0x17EF341 VA: 0x17EF240
	public bool get_IsRetval() { }

	// RVA: 0x17EF570 Offset: 0x17EF671 VA: 0x17EF570 Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x17EF580 Offset: 0x17EF681 VA: 0x17EF580 Slot: 10
	public virtual int get_Position() { }

	// RVA: 0x17EF590 Offset: 0x17EF691 VA: 0x17EF590
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EF900 Offset: 0x17EFA01 VA: 0x17EF900
	internal object GetDefaultValueImpl() { }

	// RVA: 0x17EF910 Offset: 0x17EFA11 VA: 0x17EF910 Slot: 11
	public virtual object get_DefaultValue() { }

	// RVA: 0x17EF970 Offset: 0x17EFA71 VA: 0x17EF970 Slot: 12
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF9C0 Offset: 0x17EFAC1 VA: 0x17EF9C0 Slot: 6
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17EFA20 Offset: 0x17EFB21 VA: 0x17EFA20 Slot: 13
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDFF0 Offset: 0x17EE0F1 VA: 0x17EDFF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }
}

