private class MessagePackSerializer.CompiledMethods // TypeDefIndex: 5150
{
	// Fields
	private const bool PreferInterpretation = True;
	internal readonly Func<object, MessagePackSerializerOptions, CancellationToken, byte[]> Serialize_T_Options; // 0x10
	internal readonly Action<Stream, object, MessagePackSerializerOptions, CancellationToken> Serialize_Stream_T_Options_CancellationToken; // 0x18
	internal readonly Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task> SerializeAsync_Stream_T_Options_CancellationToken; // 0x20
	internal readonly MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize Serialize_MessagePackWriter_T_Options; // 0x28
	internal readonly Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken> Serialize_IBufferWriter_T_Options_CancellationToken; // 0x30
	internal readonly MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize Deserialize_MessagePackReader_Options; // 0x38
	internal readonly Func<Stream, MessagePackSerializerOptions, CancellationToken, object> Deserialize_Stream_Options_CancellationToken; // 0x40
	internal readonly Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>> DeserializeAsync_Stream_Options_CancellationToken; // 0x48
	internal readonly Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object> Deserialize_ReadOnlyMemory_Options; // 0x50
	internal readonly Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object> Deserialize_ReadOnlySequence_Options_CancellationToken; // 0x58

	// Methods

	// RVA: 0x1698BB0 Offset: 0x1698CB1 VA: 0x1698BB0
	internal void .ctor(Type type) { }

	// RVA: 0x169ADD0 Offset: 0x169AED1 VA: 0x169ADD0
	private static MethodInfo GetMethod(string methodName, Type type, Type[] parameters) { }
}

