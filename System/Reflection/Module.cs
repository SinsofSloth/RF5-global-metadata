[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

[ComDefaultInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ClassInterfaceAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[ComVisibleAttribute] // RVA: 0xAE3B0 Offset: 0xAE4B1 VA: 0xAE3B0
[Serializable]
public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 583
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x196AF80 Offset: 0x196B081 VA: 0x196AF80
	protected void .ctor() { }

	// RVA: 0x196AF90 Offset: 0x196B091 VA: 0x196AF90 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x196AFF0 Offset: 0x196B0F1 VA: 0x196AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x196B000 Offset: 0x196B101 VA: 0x196B000 Slot: 8
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x196B050 Offset: 0x196B151 VA: 0x196B050
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x196B160 Offset: 0x196B261 VA: 0x196B160
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x196B040 Offset: 0x196B141 VA: 0x196B040
	private string GetGuidInternal() { }

	// RVA: 0x196B280 Offset: 0x196B381 VA: 0x196B280 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x196B290 Offset: 0x196B391 VA: 0x196B290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x196B2A0 Offset: 0x196B3A1 VA: 0x196B2A0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x196B2F0 Offset: 0x196B3F1 VA: 0x196B2F0 Slot: 9
	public virtual Assembly get_Assembly() { }

	// RVA: 0x196B3D0 Offset: 0x196B4D1 VA: 0x196B3D0 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x196B440 Offset: 0x196B541 VA: 0x196B440 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x196B360 Offset: 0x196B461 VA: 0x196B360
	private static Exception CreateNIE() { }

	// RVA: 0x196B4B0 Offset: 0x196B5B1 VA: 0x196B4B0 Slot: 12
	public virtual bool IsResource() { }

	// RVA: 0x196B520 Offset: 0x196B621 VA: 0x196B520 Slot: 13
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x196B590 Offset: 0x196B691 VA: 0x196B590 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x196B600 Offset: 0x196B701 VA: 0x196B600
	private static void .cctor() { }
}

