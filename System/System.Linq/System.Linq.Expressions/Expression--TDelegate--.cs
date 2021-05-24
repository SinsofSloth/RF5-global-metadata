public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 2277
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63F20 Offset: 0x2A64021 VA: 0x2A63F20
	|-Expression<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63F40 Offset: 0x2A64041 VA: 0x2A63F40
	|-Expression<object>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63FC0 Offset: 0x2A640C1 VA: 0x2A63FC0
	|-Expression<object>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A64040 Offset: 0x2A64141 VA: 0x2A64040
	|-Expression<DynamicObjectTypeFallbackFormatter.SerializeMethod>.Compile
	|-Expression<MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize>.Compile
	|-Expression<Action<object>>.Compile
	|-Expression<Func<object>>.Compile
	|-Expression<Func<IFormatterResolver, IMessagePackFormatter>>.Compile
	|-Expression<object>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A64070 Offset: 0x2A64171 VA: 0x2A64070
	|-Expression<MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize>.Compile
	|-Expression<Action<IBufferWriter<byte>, object, MessagePackSerializerOptions, CancellationToken>>.Compile
	|-Expression<Action<Stream, object, MessagePackSerializerOptions, CancellationToken>>.Compile
	|-Expression<Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>>.Compile
	|-Expression<Func<Stream, MessagePackSerializerOptions, CancellationToken, object>>.Compile
	|-Expression<Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>>.Compile
	|-Expression<Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>>.Compile
	|-Expression<Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>>.Compile
	|-Expression<Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>>.Compile
	|-Expression<object>.Compile
	*/

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0A20 Offset: 0xC0B21 VA: 0xC0A20
	// RVA: -1 Offset: -1 Slot: 18
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A64150 Offset: 0x2A64251 VA: 0x2A64150
	|-Expression<object>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A641A0 Offset: 0x2A642A1 VA: 0x2A641A0
	|-Expression<object>.Accept
	*/
}

