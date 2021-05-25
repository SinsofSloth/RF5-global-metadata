public static class MessagePackSerializer // TypeDefIndex: 5149
{
	// Fields
	private static readonly Func<Type, MessagePackSerializer.CompiledMethods> CreateCompiledMethods; // 0x0
	private static readonly ThreadsafeTypeKeyHashTable<MessagePackSerializer.CompiledMethods> Serializes; // 0x8
	private const int LZ4NotCompressionSizeInLz4BlockType = 64;
	private const int MaxHintSize = 1048576;
	[CompilerGeneratedAttribute] // RVA: 0x139940 Offset: 0x139A41 VA: 0x139940
	private static MessagePackSerializerOptions <DefaultOptions>k__BackingField; // 0x10
	[ThreadStaticAttribute] // RVA: 0x139950 Offset: 0x139A51 VA: 0x139950
	private static byte[] scratchArray; // 0x80000000
	private static readonly MessagePackSerializer.LZ4Transform LZ4CodecEncode; // 0x18
	private static readonly MessagePackSerializer.LZ4Transform LZ4CodecDecode; // 0x20

	// Properties
	public static MessagePackSerializerOptions DefaultOptions { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public static void SerializeToJson<T>(TextWriter textWriter, T obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D65D0 Offset: 0x21D66D1 VA: 0x21D65D0
	|-MessagePackSerializer.SerializeToJson<object>
	*/

	// RVA: -1 Offset: -1
	public static string SerializeToJson<T>(T obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2563850 Offset: 0x2563951 VA: 0x2563850
	|-MessagePackSerializer.SerializeToJson<object>
	*/

	// RVA: 0x1693670 Offset: 0x1693771 VA: 0x1693670
	public static string ConvertToJson(ReadOnlyMemory<byte> bytes, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1693750 Offset: 0x1693851 VA: 0x1693750
	public static string ConvertToJson(in ReadOnlySequence<byte> bytes, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1693980 Offset: 0x1693A81 VA: 0x1693980
	public static void ConvertToJson(ref MessagePackReader reader, TextWriter jsonWriter, MessagePackSerializerOptions options) { }

	// RVA: 0x1695850 Offset: 0x1695951 VA: 0x1695850
	public static void ConvertFromJson(string str, ref MessagePackWriter writer, MessagePackSerializerOptions options) { }

	// RVA: 0x1695F20 Offset: 0x1696021 VA: 0x1695F20
	public static byte[] ConvertFromJson(string str, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1695990 Offset: 0x1695A91 VA: 0x1695990
	public static void ConvertFromJson(TextReader reader, ref MessagePackWriter writer, MessagePackSerializerOptions options) { }

	// RVA: 0x16962E0 Offset: 0x16963E1 VA: 0x16962E0
	private static uint FromJsonCore(TinyJsonReader jr, ref MessagePackWriter writer) { }

	// RVA: 0x1694D10 Offset: 0x1694E11 VA: 0x1694D10
	private static void ToJsonCore(ref MessagePackReader reader, TextWriter writer, MessagePackSerializerOptions options) { }

	// RVA: 0x1697150 Offset: 0x1697251 VA: 0x1697150
	private static void WriteJsonString(string value, TextWriter builder) { }

	// RVA: 0x16972F0 Offset: 0x16973F1 VA: 0x16972F0
	private static void .cctor() { }

	// RVA: 0x1697500 Offset: 0x1697601 VA: 0x1697500
	public static void Serialize(Type type, ref MessagePackWriter writer, object obj, MessagePackSerializerOptions options) { }

	// RVA: 0x16976A0 Offset: 0x16977A1 VA: 0x16976A0
	public static void Serialize(Type type, IBufferWriter<byte> writer, object obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x16977D0 Offset: 0x16978D1 VA: 0x16977D0
	public static byte[] Serialize(Type type, object obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x16978F0 Offset: 0x16979F1 VA: 0x16978F0
	public static void Serialize(Type type, Stream stream, object obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1697A20 Offset: 0x1697B21 VA: 0x1697A20
	public static Task SerializeAsync(Type type, Stream stream, object obj, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1697B50 Offset: 0x1697C51 VA: 0x1697B50
	public static object Deserialize(Type type, ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1697C60 Offset: 0x1697D61 VA: 0x1697C60
	public static object Deserialize(Type type, Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1697D80 Offset: 0x1697E81 VA: 0x1697D80
	public static ValueTask<object> DeserializeAsync(Type type, Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1697EB0 Offset: 0x1697FB1 VA: 0x1697EB0
	public static object Deserialize(Type type, ReadOnlyMemory<byte> bytes, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x1697FE0 Offset: 0x16980E1 VA: 0x1697FE0
	public static object Deserialize(Type type, ReadOnlySequence<byte> bytes, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x13A060 Offset: 0x13A161 VA: 0x13A060
	// RVA: -1 Offset: -1
	private static ValueTask<object> DeserializeObjectAsync<T>(Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CD9D0 Offset: 0x21CDAD1 VA: 0x21CD9D0
	|-MessagePackSerializer.DeserializeObjectAsync<object>
	*/

	// RVA: 0x1697610 Offset: 0x1697711 VA: 0x1697610
	private static MessagePackSerializer.CompiledMethods GetOrAdd(Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A0D0 Offset: 0x13A1D1 VA: 0x13A0D0
	// RVA: 0x1698130 Offset: 0x1698231 VA: 0x1698130
	public static MessagePackSerializerOptions get_DefaultOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A0E0 Offset: 0x13A1E1 VA: 0x13A0E0
	// RVA: 0x16981A0 Offset: 0x16982A1 VA: 0x16981A0
	public static void set_DefaultOptions(MessagePackSerializerOptions value) { }

	// RVA: -1 Offset: -1
	public static void Serialize<T>(IBufferWriter<byte> writer, T value, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6130 Offset: 0x21D6231 VA: 0x21D6130
	|-MessagePackSerializer.Serialize<object>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<T>(ref MessagePackWriter writer, T value, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D23F0 Offset: 0x21D24F1 VA: 0x21D23F0
	|-MessagePackSerializer.Serialize<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D2C30 Offset: 0x21D2D31 VA: 0x21D2C30
	|-MessagePackSerializer.Serialize<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D33B0 Offset: 0x21D34B1 VA: 0x21D33B0
	|-MessagePackSerializer.Serialize<MonsterHutSaveData>
	|
	|-RVA: 0x21D3BB0 Offset: 0x21D3CB1 VA: 0x21D3BB0
	|-MessagePackSerializer.Serialize<OrderSaveData>
	|
	|-RVA: 0x21D43B0 Offset: 0x21D44B1 VA: 0x21D43B0
	|-MessagePackSerializer.Serialize<bool>
	|
	|-RVA: 0x21D4B10 Offset: 0x21D4C11 VA: 0x21D4B10
	|-MessagePackSerializer.Serialize<int>
	|
	|-RVA: 0x21D5270 Offset: 0x21D5371 VA: 0x21D5270
	|-MessagePackSerializer.Serialize<Int32Enum>
	|
	|-RVA: 0x21D59D0 Offset: 0x21D5AD1 VA: 0x21D59D0
	|-MessagePackSerializer.Serialize<object>
	*/

	// RVA: -1 Offset: -1
	public static byte[] Serialize<T>(T value, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D38A0 Offset: 0x22D39A1 VA: 0x22D38A0
	|-MessagePackSerializer.Serialize<ChildData>
	|-MessagePackSerializer.Serialize<EventSaveParameter>
	|-MessagePackSerializer.Serialize<FieldOnGroundItemStorage>
	|-MessagePackSerializer.Serialize<FriendMonsterStatusData>
	|-MessagePackSerializer.Serialize<GiveBirthSaveParameter>
	|-MessagePackSerializer.Serialize<HumanStatusData>
	|-MessagePackSerializer.Serialize<ItemStorageData>
	|-MessagePackSerializer.Serialize<NpcDateSaveParameter>
	|-MessagePackSerializer.Serialize<NpcSaveParameter>
	|-MessagePackSerializer.Serialize<PartyData>
	|-MessagePackSerializer.Serialize<FishShipmentRecords>
	|-MessagePackSerializer.Serialize<SeedLevelRecords>
	|-MessagePackSerializer.Serialize<ShipmentItemRecords>
	|-MessagePackSerializer.Serialize<SubEventSaveData>
	|-MessagePackSerializer.Serialize<object>
	|
	|-RVA: 0x22D2A30 Offset: 0x22D2B31 VA: 0x22D2A30
	|-MessagePackSerializer.Serialize<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x22D2C70 Offset: 0x22D2D71 VA: 0x22D2C70
	|-MessagePackSerializer.Serialize<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x22D2E70 Offset: 0x22D2F71 VA: 0x22D2E70
	|-MessagePackSerializer.Serialize<MonsterHutSaveData>
	|
	|-RVA: 0x22D30A0 Offset: 0x22D31A1 VA: 0x22D30A0
	|-MessagePackSerializer.Serialize<OrderSaveData>
	|
	|-RVA: 0x22D32D0 Offset: 0x22D33D1 VA: 0x22D32D0
	|-MessagePackSerializer.Serialize<bool>
	|
	|-RVA: 0x22D34C0 Offset: 0x22D35C1 VA: 0x22D34C0
	|-MessagePackSerializer.Serialize<int>
	|
	|-RVA: 0x22D36B0 Offset: 0x22D37B1 VA: 0x22D36B0
	|-MessagePackSerializer.Serialize<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	public static void Serialize<T>(Stream stream, T value, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6290 Offset: 0x21D6391 VA: 0x21D6290
	|-MessagePackSerializer.Serialize<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x13A0F0 Offset: 0x13A1F1 VA: 0x13A0F0
	// RVA: -1 Offset: -1
	public static Task SerializeAsync<T>(Stream stream, T value, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CB930 Offset: 0x21CBA31 VA: 0x21CB930
	|-MessagePackSerializer.SerializeAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(in ReadOnlySequence<byte> byteSequence, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C58F0 Offset: 0x23C59F1 VA: 0x23C58F0
	|-MessagePackSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C15F0 Offset: 0x23C16F1 VA: 0x23C15F0
	|-MessagePackSerializer.Deserialize<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x23C1EF0 Offset: 0x23C1FF1 VA: 0x23C1EF0
	|-MessagePackSerializer.Deserialize<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x23C2750 Offset: 0x23C2851 VA: 0x23C2750
	|-MessagePackSerializer.Deserialize<MonsterHutSaveData>
	|
	|-RVA: 0x23C3020 Offset: 0x23C3121 VA: 0x23C3020
	|-MessagePackSerializer.Deserialize<OrderSaveData>
	|
	|-RVA: 0x23C38F0 Offset: 0x23C39F1 VA: 0x23C38F0
	|-MessagePackSerializer.Deserialize<bool>
	|
	|-RVA: 0x23C4140 Offset: 0x23C4241 VA: 0x23C4140
	|-MessagePackSerializer.Deserialize<int>
	|
	|-RVA: 0x23C4990 Offset: 0x23C4A91 VA: 0x23C4990
	|-MessagePackSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0x23C51E0 Offset: 0x23C52E1 VA: 0x23C51E0
	|-MessagePackSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(ReadOnlyMemory<byte> buffer, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C60C0 Offset: 0x23C61C1 VA: 0x23C60C0
	|-MessagePackSerializer.Deserialize<ChildData>
	|-MessagePackSerializer.Deserialize<EventSaveParameter>
	|-MessagePackSerializer.Deserialize<FieldOnGroundItemStorage>
	|-MessagePackSerializer.Deserialize<FriendMonsterStatusData>
	|-MessagePackSerializer.Deserialize<GiveBirthSaveParameter>
	|-MessagePackSerializer.Deserialize<HumanStatusData>
	|-MessagePackSerializer.Deserialize<ItemStorageData>
	|-MessagePackSerializer.Deserialize<NpcDateSaveParameter>
	|-MessagePackSerializer.Deserialize<NpcSaveParameter>
	|-MessagePackSerializer.Deserialize<PartyData>
	|-MessagePackSerializer.Deserialize<SubEventSaveData>
	|-MessagePackSerializer.Deserialize<object>
	|
	|-RVA: 0x23C1D90 Offset: 0x23C1E91 VA: 0x23C1D90
	|-MessagePackSerializer.Deserialize<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x23C2610 Offset: 0x23C2711 VA: 0x23C2610
	|-MessagePackSerializer.Deserialize<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x23C2EC0 Offset: 0x23C2FC1 VA: 0x23C2EC0
	|-MessagePackSerializer.Deserialize<MonsterHutSaveData>
	|
	|-RVA: 0x23C3790 Offset: 0x23C3891 VA: 0x23C3790
	|-MessagePackSerializer.Deserialize<OrderSaveData>
	|
	|-RVA: 0x23C4000 Offset: 0x23C4101 VA: 0x23C4000
	|-MessagePackSerializer.Deserialize<bool>
	|
	|-RVA: 0x23C4850 Offset: 0x23C4951 VA: 0x23C4850
	|-MessagePackSerializer.Deserialize<int>
	|
	|-RVA: 0x23C50A0 Offset: 0x23C51A1 VA: 0x23C50A0
	|-MessagePackSerializer.Deserialize<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(ReadOnlyMemory<byte> buffer, out int bytesRead, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C6200 Offset: 0x23C6301 VA: 0x23C6200
	|-MessagePackSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(ReadOnlyMemory<byte> buffer, MessagePackSerializerOptions options, out int bytesRead, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C5EE0 Offset: 0x23C5FE1 VA: 0x23C5EE0
	|-MessagePackSerializer.Deserialize<object>
	*/

	// RVA: -1 Offset: -1
	public static T Deserialize<T>(Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C5A50 Offset: 0x23C5B51 VA: 0x23C5A50
	|-MessagePackSerializer.Deserialize<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x13A160 Offset: 0x13A261 VA: 0x13A160
	// RVA: -1 Offset: -1
	public static ValueTask<T> DeserializeAsync<T>(Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CDB80 Offset: 0x21CDC81 VA: 0x21CDB80
	|-MessagePackSerializer.DeserializeAsync<object>
	*/

	// RVA: -1 Offset: -1
	private static bool TryDeserializeFromMemoryStream<T>(Stream stream, MessagePackSerializerOptions options, CancellationToken cancellationToken, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519250 Offset: 0x2519351 VA: 0x2519250
	|-MessagePackSerializer.TryDeserializeFromMemoryStream<object>
	*/

	// RVA: -1 Offset: -1
	private static T DeserializeFromSequenceAndRewindStreamIfPossible<T>(Stream streamToRewind, MessagePackSerializerOptions options, ReadOnlySequence<byte> sequence, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C62A0 Offset: 0x23C63A1 VA: 0x23C62A0
	|-MessagePackSerializer.DeserializeFromSequenceAndRewindStreamIfPossible<object>
	*/

	// RVA: 0x1698210 Offset: 0x1698311 VA: 0x1698210
	private static int LZ4Operation(in ReadOnlySequence<byte> input, Span<byte> output, MessagePackSerializer.LZ4Transform lz4Operation) { }

	// RVA: 0x1693F50 Offset: 0x1694051 VA: 0x1693F50
	private static bool TryDecompress(ref MessagePackReader reader, IBufferWriter<byte> writer) { }

	// RVA: 0x1696880 Offset: 0x1696981 VA: 0x1696880
	private static void ToLZ4BinaryCore(in ReadOnlySequence<byte> msgpackUncompressedData, ref MessagePackWriter writer, MessagePackCompression compression) { }

	// RVA: 0x1698630 Offset: 0x1698731 VA: 0x1698630
	private static int GetUInt32WriteSize(uint value) { }

	// RVA: 0x1698670 Offset: 0x1698771 VA: 0x1698670
	private static void WriteBin32Header(uint value, Span<byte> span) { }

	// RVA: 0x1698740 Offset: 0x1698841 VA: 0x1698740
	private static bool IsMessagePackFixedSizePrimitiveTypeHelper(Type type) { }
}

