public abstract class SaveDataBase // TypeDefIndex: 9910
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA10 Offset: 0x17FB11 VA: 0x17FA10
	private SaveDataHeader <SaveDataHeader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FA20 Offset: 0x17FB21 VA: 0x17FA20
	private SaveDataFooter <SaveDataFooter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FA30 Offset: 0x17FB31 VA: 0x17FA30
	private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField; // 0x20

	// Properties
	public abstract uint Version { get; }
	public SaveDataHeader SaveDataHeader { get; set; }
	public SaveDataFooter SaveDataFooter { get; set; }
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3A0 Offset: 0x1AD4A1 VA: 0x1AD3A0
	// RVA: 0x20F6540 Offset: 0x20F6641 VA: 0x20F6540
	public SaveDataHeader get_SaveDataHeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3B0 Offset: 0x1AD4B1 VA: 0x1AD3B0
	// RVA: 0x20F6550 Offset: 0x20F6651 VA: 0x20F6550
	private void set_SaveDataHeader(SaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3C0 Offset: 0x1AD4C1 VA: 0x1AD3C0
	// RVA: 0x20F6560 Offset: 0x20F6661 VA: 0x20F6560
	public SaveDataFooter get_SaveDataFooter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3D0 Offset: 0x1AD4D1 VA: 0x1AD3D0
	// RVA: 0x20F6570 Offset: 0x20F6671 VA: 0x20F6570
	private void set_SaveDataFooter(SaveDataFooter value) { }

	// RVA: 0x20F6580 Offset: 0x20F6681 VA: 0x20F6580
	public void .ctor() { }

	// RVA: 0x20F6800 Offset: 0x20F6901 VA: 0x20F6800 Slot: 5
	public virtual void Initialize() { }

	// RVA: 0x20F6840 Offset: 0x20F6941 VA: 0x20F6840 Slot: 6
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Load(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeforeSave() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AfterLoad() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete(SaveControllerBase controller) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3E0 Offset: 0x1AD4E1 VA: 0x1AD3E0
	// RVA: 0x20F6970 Offset: 0x20F6A71 VA: 0x20F6970 Slot: 12
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> get_VersionReader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3F0 Offset: 0x1AD4F1 VA: 0x1AD3F0
	// RVA: 0x20F6980 Offset: 0x20F6A81 VA: 0x20F6980 Slot: 13
	protected virtual void set_VersionReader(Dictionary<uint, SaveDataBase.ReaderFunc> value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void VersionInitialize() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20F6990 Offset: 0x20F6A91 VA: 0x20F6990
	public static int RoundBlockSize(int length, int block_size) { }

	// RVA: 0x20F69B0 Offset: 0x20F6AB1 VA: 0x20F69B0
	protected byte[] Write() { }

	// RVA: 0x20F6E90 Offset: 0x20F6F91 VA: 0x20F6E90
	protected ErrorCode Read(byte[] data) { }

	// RVA: 0x20F52D0 Offset: 0x20F53D1 VA: 0x20F52D0
	public static void FixedStringWriter(BinaryWriter writer, string text, int length) { }

	// RVA: 0x20F5440 Offset: 0x20F5541 VA: 0x20F5440
	public static string FixedStringReader(BinaryReader reader, int length) { }

	// RVA: 0x20F7210 Offset: 0x20F7311 VA: 0x20F7210
	protected bool CheckSum(uint sum, byte[] data, int length) { }

	// RVA: 0x20F6D90 Offset: 0x20F6E91 VA: 0x20F6D90
	protected uint MakeSum(byte[] data, int length) { }
}

public abstract class SaveDataBase // TypeDefIndex: 9910
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA10 Offset: 0x17FB11 VA: 0x17FA10
	private SaveDataHeader <SaveDataHeader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FA20 Offset: 0x17FB21 VA: 0x17FA20
	private SaveDataFooter <SaveDataFooter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FA30 Offset: 0x17FB31 VA: 0x17FA30
	private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField; // 0x20

	// Properties
	public abstract uint Version { get; }
	public SaveDataHeader SaveDataHeader { get; set; }
	public SaveDataFooter SaveDataFooter { get; set; }
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3A0 Offset: 0x1AD4A1 VA: 0x1AD3A0
	// RVA: 0x20F6540 Offset: 0x20F6641 VA: 0x20F6540
	public SaveDataHeader get_SaveDataHeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3B0 Offset: 0x1AD4B1 VA: 0x1AD3B0
	// RVA: 0x20F6550 Offset: 0x20F6651 VA: 0x20F6550
	private void set_SaveDataHeader(SaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3C0 Offset: 0x1AD4C1 VA: 0x1AD3C0
	// RVA: 0x20F6560 Offset: 0x20F6661 VA: 0x20F6560
	public SaveDataFooter get_SaveDataFooter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3D0 Offset: 0x1AD4D1 VA: 0x1AD3D0
	// RVA: 0x20F6570 Offset: 0x20F6671 VA: 0x20F6570
	private void set_SaveDataFooter(SaveDataFooter value) { }

	// RVA: 0x20F6580 Offset: 0x20F6681 VA: 0x20F6580
	public void .ctor() { }

	// RVA: 0x20F6800 Offset: 0x20F6901 VA: 0x20F6800 Slot: 5
	public virtual void Initialize() { }

	// RVA: 0x20F6840 Offset: 0x20F6941 VA: 0x20F6840 Slot: 6
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Load(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeforeSave() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AfterLoad() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete(SaveControllerBase controller) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3E0 Offset: 0x1AD4E1 VA: 0x1AD3E0
	// RVA: 0x20F6970 Offset: 0x20F6A71 VA: 0x20F6970 Slot: 12
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> get_VersionReader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3F0 Offset: 0x1AD4F1 VA: 0x1AD3F0
	// RVA: 0x20F6980 Offset: 0x20F6A81 VA: 0x20F6980 Slot: 13
	protected virtual void set_VersionReader(Dictionary<uint, SaveDataBase.ReaderFunc> value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void VersionInitialize() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20F6990 Offset: 0x20F6A91 VA: 0x20F6990
	public static int RoundBlockSize(int length, int block_size) { }

	// RVA: 0x20F69B0 Offset: 0x20F6AB1 VA: 0x20F69B0
	protected byte[] Write() { }

	// RVA: 0x20F6E90 Offset: 0x20F6F91 VA: 0x20F6E90
	protected ErrorCode Read(byte[] data) { }

	// RVA: 0x20F52D0 Offset: 0x20F53D1 VA: 0x20F52D0
	public static void FixedStringWriter(BinaryWriter writer, string text, int length) { }

	// RVA: 0x20F5440 Offset: 0x20F5541 VA: 0x20F5440
	public static string FixedStringReader(BinaryReader reader, int length) { }

	// RVA: 0x20F7210 Offset: 0x20F7311 VA: 0x20F7210
	protected bool CheckSum(uint sum, byte[] data, int length) { }

	// RVA: 0x20F6D90 Offset: 0x20F6E91 VA: 0x20F6D90
	protected uint MakeSum(byte[] data, int length) { }
}

public abstract class SaveDataBase // TypeDefIndex: 9910
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA10 Offset: 0x17FB11 VA: 0x17FA10
	private SaveDataHeader <SaveDataHeader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FA20 Offset: 0x17FB21 VA: 0x17FA20
	private SaveDataFooter <SaveDataFooter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FA30 Offset: 0x17FB31 VA: 0x17FA30
	private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField; // 0x20

	// Properties
	public abstract uint Version { get; }
	public SaveDataHeader SaveDataHeader { get; set; }
	public SaveDataFooter SaveDataFooter { get; set; }
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3A0 Offset: 0x1AD4A1 VA: 0x1AD3A0
	// RVA: 0x20F6540 Offset: 0x20F6641 VA: 0x20F6540
	public SaveDataHeader get_SaveDataHeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3B0 Offset: 0x1AD4B1 VA: 0x1AD3B0
	// RVA: 0x20F6550 Offset: 0x20F6651 VA: 0x20F6550
	private void set_SaveDataHeader(SaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3C0 Offset: 0x1AD4C1 VA: 0x1AD3C0
	// RVA: 0x20F6560 Offset: 0x20F6661 VA: 0x20F6560
	public SaveDataFooter get_SaveDataFooter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3D0 Offset: 0x1AD4D1 VA: 0x1AD3D0
	// RVA: 0x20F6570 Offset: 0x20F6671 VA: 0x20F6570
	private void set_SaveDataFooter(SaveDataFooter value) { }

	// RVA: 0x20F6580 Offset: 0x20F6681 VA: 0x20F6580
	public void .ctor() { }

	// RVA: 0x20F6800 Offset: 0x20F6901 VA: 0x20F6800 Slot: 5
	public virtual void Initialize() { }

	// RVA: 0x20F6840 Offset: 0x20F6941 VA: 0x20F6840 Slot: 6
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Load(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeforeSave() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AfterLoad() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete(SaveControllerBase controller) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3E0 Offset: 0x1AD4E1 VA: 0x1AD3E0
	// RVA: 0x20F6970 Offset: 0x20F6A71 VA: 0x20F6970 Slot: 12
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> get_VersionReader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3F0 Offset: 0x1AD4F1 VA: 0x1AD3F0
	// RVA: 0x20F6980 Offset: 0x20F6A81 VA: 0x20F6980 Slot: 13
	protected virtual void set_VersionReader(Dictionary<uint, SaveDataBase.ReaderFunc> value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void VersionInitialize() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20F6990 Offset: 0x20F6A91 VA: 0x20F6990
	public static int RoundBlockSize(int length, int block_size) { }

	// RVA: 0x20F69B0 Offset: 0x20F6AB1 VA: 0x20F69B0
	protected byte[] Write() { }

	// RVA: 0x20F6E90 Offset: 0x20F6F91 VA: 0x20F6E90
	protected ErrorCode Read(byte[] data) { }

	// RVA: 0x20F52D0 Offset: 0x20F53D1 VA: 0x20F52D0
	public static void FixedStringWriter(BinaryWriter writer, string text, int length) { }

	// RVA: 0x20F5440 Offset: 0x20F5541 VA: 0x20F5440
	public static string FixedStringReader(BinaryReader reader, int length) { }

	// RVA: 0x20F7210 Offset: 0x20F7311 VA: 0x20F7210
	protected bool CheckSum(uint sum, byte[] data, int length) { }

	// RVA: 0x20F6D90 Offset: 0x20F6E91 VA: 0x20F6D90
	protected uint MakeSum(byte[] data, int length) { }
}

public abstract class SaveDataBase // TypeDefIndex: 9910
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA10 Offset: 0x17FB11 VA: 0x17FA10
	private SaveDataHeader <SaveDataHeader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FA20 Offset: 0x17FB21 VA: 0x17FA20
	private SaveDataFooter <SaveDataFooter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FA30 Offset: 0x17FB31 VA: 0x17FA30
	private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField; // 0x20

	// Properties
	public abstract uint Version { get; }
	public SaveDataHeader SaveDataHeader { get; set; }
	public SaveDataFooter SaveDataFooter { get; set; }
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3A0 Offset: 0x1AD4A1 VA: 0x1AD3A0
	// RVA: 0x20F6540 Offset: 0x20F6641 VA: 0x20F6540
	public SaveDataHeader get_SaveDataHeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3B0 Offset: 0x1AD4B1 VA: 0x1AD3B0
	// RVA: 0x20F6550 Offset: 0x20F6651 VA: 0x20F6550
	private void set_SaveDataHeader(SaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3C0 Offset: 0x1AD4C1 VA: 0x1AD3C0
	// RVA: 0x20F6560 Offset: 0x20F6661 VA: 0x20F6560
	public SaveDataFooter get_SaveDataFooter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3D0 Offset: 0x1AD4D1 VA: 0x1AD3D0
	// RVA: 0x20F6570 Offset: 0x20F6671 VA: 0x20F6570
	private void set_SaveDataFooter(SaveDataFooter value) { }

	// RVA: 0x20F6580 Offset: 0x20F6681 VA: 0x20F6580
	public void .ctor() { }

	// RVA: 0x20F6800 Offset: 0x20F6901 VA: 0x20F6800 Slot: 5
	public virtual void Initialize() { }

	// RVA: 0x20F6840 Offset: 0x20F6941 VA: 0x20F6840 Slot: 6
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Load(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeforeSave() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AfterLoad() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete(SaveControllerBase controller) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3E0 Offset: 0x1AD4E1 VA: 0x1AD3E0
	// RVA: 0x20F6970 Offset: 0x20F6A71 VA: 0x20F6970 Slot: 12
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> get_VersionReader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3F0 Offset: 0x1AD4F1 VA: 0x1AD3F0
	// RVA: 0x20F6980 Offset: 0x20F6A81 VA: 0x20F6980 Slot: 13
	protected virtual void set_VersionReader(Dictionary<uint, SaveDataBase.ReaderFunc> value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void VersionInitialize() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20F6990 Offset: 0x20F6A91 VA: 0x20F6990
	public static int RoundBlockSize(int length, int block_size) { }

	// RVA: 0x20F69B0 Offset: 0x20F6AB1 VA: 0x20F69B0
	protected byte[] Write() { }

	// RVA: 0x20F6E90 Offset: 0x20F6F91 VA: 0x20F6E90
	protected ErrorCode Read(byte[] data) { }

	// RVA: 0x20F52D0 Offset: 0x20F53D1 VA: 0x20F52D0
	public static void FixedStringWriter(BinaryWriter writer, string text, int length) { }

	// RVA: 0x20F5440 Offset: 0x20F5541 VA: 0x20F5440
	public static string FixedStringReader(BinaryReader reader, int length) { }

	// RVA: 0x20F7210 Offset: 0x20F7311 VA: 0x20F7210
	protected bool CheckSum(uint sum, byte[] data, int length) { }

	// RVA: 0x20F6D90 Offset: 0x20F6E91 VA: 0x20F6D90
	protected uint MakeSum(byte[] data, int length) { }
}

public abstract class SaveDataBase // TypeDefIndex: 9910
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FA10 Offset: 0x17FB11 VA: 0x17FA10
	private SaveDataHeader <SaveDataHeader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x17FA20 Offset: 0x17FB21 VA: 0x17FA20
	private SaveDataFooter <SaveDataFooter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x17FA30 Offset: 0x17FB31 VA: 0x17FA30
	private Dictionary<uint, SaveDataBase.ReaderFunc> <VersionReader>k__BackingField; // 0x20

	// Properties
	public abstract uint Version { get; }
	public SaveDataHeader SaveDataHeader { get; set; }
	public SaveDataFooter SaveDataFooter { get; set; }
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> VersionReader { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3A0 Offset: 0x1AD4A1 VA: 0x1AD3A0
	// RVA: 0x20F6540 Offset: 0x20F6641 VA: 0x20F6540
	public SaveDataHeader get_SaveDataHeader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3B0 Offset: 0x1AD4B1 VA: 0x1AD3B0
	// RVA: 0x20F6550 Offset: 0x20F6651 VA: 0x20F6550
	private void set_SaveDataHeader(SaveDataHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3C0 Offset: 0x1AD4C1 VA: 0x1AD3C0
	// RVA: 0x20F6560 Offset: 0x20F6661 VA: 0x20F6560
	public SaveDataFooter get_SaveDataFooter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3D0 Offset: 0x1AD4D1 VA: 0x1AD3D0
	// RVA: 0x20F6570 Offset: 0x20F6671 VA: 0x20F6570
	private void set_SaveDataFooter(SaveDataFooter value) { }

	// RVA: 0x20F6580 Offset: 0x20F6681 VA: 0x20F6580
	public void .ctor() { }

	// RVA: 0x20F6800 Offset: 0x20F6901 VA: 0x20F6800 Slot: 5
	public virtual void Initialize() { }

	// RVA: 0x20F6840 Offset: 0x20F6941 VA: 0x20F6840 Slot: 6
	public virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Load(SaveControllerBase controller) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void BeforeSave() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AfterLoad() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete(SaveControllerBase controller) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3E0 Offset: 0x1AD4E1 VA: 0x1AD3E0
	// RVA: 0x20F6970 Offset: 0x20F6A71 VA: 0x20F6970 Slot: 12
	protected virtual Dictionary<uint, SaveDataBase.ReaderFunc> get_VersionReader() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD3F0 Offset: 0x1AD4F1 VA: 0x1AD3F0
	// RVA: 0x20F6980 Offset: 0x20F6A81 VA: 0x20F6980 Slot: 13
	protected virtual void set_VersionReader(Dictionary<uint, SaveDataBase.ReaderFunc> value) { }

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void VersionInitialize() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void VersionWriter(BinaryWriter writer) { }

	// RVA: 0x20F6990 Offset: 0x20F6A91 VA: 0x20F6990
	public static int RoundBlockSize(int length, int block_size) { }

	// RVA: 0x20F69B0 Offset: 0x20F6AB1 VA: 0x20F69B0
	protected byte[] Write() { }

	// RVA: 0x20F6E90 Offset: 0x20F6F91 VA: 0x20F6E90
	protected ErrorCode Read(byte[] data) { }

	// RVA: 0x20F52D0 Offset: 0x20F53D1 VA: 0x20F52D0
	public static void FixedStringWriter(BinaryWriter writer, string text, int length) { }

	// RVA: 0x20F5440 Offset: 0x20F5541 VA: 0x20F5440
	public static string FixedStringReader(BinaryReader reader, int length) { }

	// RVA: 0x20F7210 Offset: 0x20F7311 VA: 0x20F7210
	protected bool CheckSum(uint sum, byte[] data, int length) { }

	// RVA: 0x20F6D90 Offset: 0x20F6E91 VA: 0x20F6D90
	protected uint MakeSum(byte[] data, int length) { }
}

