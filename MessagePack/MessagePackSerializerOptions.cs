public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

public class MessagePackSerializerOptions // TypeDefIndex: 5160
{
	// Fields
	internal static readonly Regex AssemblyNameVersionSelectorRegex; // 0x0
	private static readonly HashSet<string> DisallowedTypes; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x139960 Offset: 0x139A61 VA: 0x139960
	private IFormatterResolver <Resolver>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139970 Offset: 0x139A71 VA: 0x139970
	private MessagePackCompression <Compression>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139980 Offset: 0x139A81 VA: 0x139980
	private Nullable<bool> <OldSpec>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x139990 Offset: 0x139A91 VA: 0x139990
	private bool <OmitAssemblyVersion>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1399A0 Offset: 0x139AA1 VA: 0x1399A0
	private bool <AllowAssemblyVersionMismatch>k__BackingField; // 0x1F
	[CompilerGeneratedAttribute] // RVA: 0x1399B0 Offset: 0x139AB1 VA: 0x1399B0
	private MessagePackSecurity <Security>k__BackingField; // 0x20

	// Properties
	public static MessagePackSerializerOptions Standard { get; }
	public IFormatterResolver Resolver { get; set; }
	public MessagePackCompression Compression { get; set; }
	public Nullable<bool> OldSpec { get; set; }
	public bool OmitAssemblyVersion { get; set; }
	public bool AllowAssemblyVersionMismatch { get; set; }
	public MessagePackSecurity Security { get; set; }

	// Methods

	// RVA: 0x14EA0D0 Offset: 0x14EA1D1 VA: 0x14EA0D0
	public static MessagePackSerializerOptions get_Standard() { }

	// RVA: 0x14EA140 Offset: 0x14EA241 VA: 0x14EA140
	protected internal void .ctor(IFormatterResolver resolver) { }

	// RVA: 0x14EA230 Offset: 0x14EA331 VA: 0x14EA230
	protected void .ctor(MessagePackSerializerOptions copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1D0 Offset: 0x13A2D1 VA: 0x13A1D0
	// RVA: 0x14EA340 Offset: 0x14EA441 VA: 0x14EA340
	public IFormatterResolver get_Resolver() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1E0 Offset: 0x13A2E1 VA: 0x13A1E0
	// RVA: 0x14EA350 Offset: 0x14EA451 VA: 0x14EA350
	private void set_Resolver(IFormatterResolver value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A1F0 Offset: 0x13A2F1 VA: 0x13A1F0
	// RVA: 0x14EA360 Offset: 0x14EA461 VA: 0x14EA360
	public MessagePackCompression get_Compression() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A200 Offset: 0x13A301 VA: 0x13A200
	// RVA: 0x14EA370 Offset: 0x14EA471 VA: 0x14EA370
	private void set_Compression(MessagePackCompression value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A210 Offset: 0x13A311 VA: 0x13A210
	// RVA: 0x14EA380 Offset: 0x14EA481 VA: 0x14EA380
	public Nullable<bool> get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A220 Offset: 0x13A321 VA: 0x13A220
	// RVA: 0x14EA390 Offset: 0x14EA491 VA: 0x14EA390
	private void set_OldSpec(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A230 Offset: 0x13A331 VA: 0x13A230
	// RVA: 0x14EA3A0 Offset: 0x14EA4A1 VA: 0x14EA3A0
	public bool get_OmitAssemblyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A240 Offset: 0x13A341 VA: 0x13A240
	// RVA: 0x14EA3B0 Offset: 0x14EA4B1 VA: 0x14EA3B0
	private void set_OmitAssemblyVersion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A250 Offset: 0x13A351 VA: 0x13A250
	// RVA: 0x14EA3C0 Offset: 0x14EA4C1 VA: 0x14EA3C0
	public bool get_AllowAssemblyVersionMismatch() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A260 Offset: 0x13A361 VA: 0x13A260
	// RVA: 0x14EA3D0 Offset: 0x14EA4D1 VA: 0x14EA3D0
	private void set_AllowAssemblyVersionMismatch(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A270 Offset: 0x13A371 VA: 0x13A270
	// RVA: 0x14EA3E0 Offset: 0x14EA4E1 VA: 0x14EA3E0
	public MessagePackSecurity get_Security() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A280 Offset: 0x13A381 VA: 0x13A280
	// RVA: 0x14EA3F0 Offset: 0x14EA4F1 VA: 0x14EA3F0
	private void set_Security(MessagePackSecurity value) { }

	// RVA: 0x14EA400 Offset: 0x14EA501 VA: 0x14EA400 Slot: 4
	public virtual Type LoadType(string typeName) { }

	// RVA: 0x14EA590 Offset: 0x14EA691 VA: 0x14EA590 Slot: 5
	public virtual void ThrowIfDeserializingTypeIsDisallowed(Type type) { }

	// RVA: 0x14EA6B0 Offset: 0x14EA7B1 VA: 0x14EA6B0
	public MessagePackSerializerOptions WithResolver(IFormatterResolver resolver) { }

	// RVA: 0x14EA710 Offset: 0x14EA811 VA: 0x14EA710
	public MessagePackSerializerOptions WithCompression(MessagePackCompression compression) { }

	// RVA: 0x14EA750 Offset: 0x14EA851 VA: 0x14EA750
	public MessagePackSerializerOptions WithOldSpec(Nullable<bool> oldSpec /*Metadata offset 0x7401E1*/) { }

	// RVA: 0x14EA800 Offset: 0x14EA901 VA: 0x14EA800
	public MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion) { }

	// RVA: 0x14EA850 Offset: 0x14EA951 VA: 0x14EA850
	public MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch) { }

	// RVA: 0x14EA8A0 Offset: 0x14EA9A1 VA: 0x14EA8A0
	public MessagePackSerializerOptions WithSecurity(MessagePackSecurity security) { }

	// RVA: 0x14EA970 Offset: 0x14EAA71 VA: 0x14EA970 Slot: 6
	protected virtual MessagePackSerializerOptions Clone() { }

	// RVA: 0x14EAAC0 Offset: 0x14EABC1 VA: 0x14EAAC0
	private static void .cctor() { }
}

