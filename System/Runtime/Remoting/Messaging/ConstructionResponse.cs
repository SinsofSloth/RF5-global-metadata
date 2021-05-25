[CLSCompliantAttribute] // RVA: 0xB11B0 Offset: 0xB12B1 VA: 0xB11B0
[ComVisibleAttribute] // RVA: 0xB11B0 Offset: 0xB12B1 VA: 0xB11B0
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 1207
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x1753240 Offset: 0x1753341 VA: 0x1753240
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x1753380 Offset: 0x1753481 VA: 0x1753380
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x1753390 Offset: 0x1753491 VA: 0x1753390
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1753430 Offset: 0x1753531 VA: 0x1753430 Slot: 22
	public override IDictionary get_Properties() { }
}

