public static class NpadJoy // TypeDefIndex: 11575
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x26B2C10 Offset: 0x26B2D11 VA: 0x26B2C10
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x26B2C20 Offset: 0x26B2D21 VA: 0x26B2C20
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x26B2C30 Offset: 0x26B2D31 VA: 0x26B2C30
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C40 Offset: 0x26B2D41 VA: 0x26B2C40
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x26B2C60 Offset: 0x26B2D61 VA: 0x26B2C60
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C80 Offset: 0x26B2D81 VA: 0x26B2C80
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C90 Offset: 0x26B2D91 VA: 0x26B2C90
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x26B2CA0 Offset: 0x26B2DA1 VA: 0x26B2CA0
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x26B2CB0 Offset: 0x26B2DB1 VA: 0x26B2CB0
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x26B2CC0 Offset: 0x26B2DC1 VA: 0x26B2CC0
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x26B2CD0 Offset: 0x26B2DD1 VA: 0x26B2CD0
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x26B2CE0 Offset: 0x26B2DE1 VA: 0x26B2CE0
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x26B2CF0 Offset: 0x26B2DF1 VA: 0x26B2CF0
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x26B2D00 Offset: 0x26B2E01 VA: 0x26B2D00
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x26B2D10 Offset: 0x26B2E11 VA: 0x26B2D10
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x26B2D20 Offset: 0x26B2E21 VA: 0x26B2D20
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

public static class NpadJoy // TypeDefIndex: 11575
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x26B2C10 Offset: 0x26B2D11 VA: 0x26B2C10
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x26B2C20 Offset: 0x26B2D21 VA: 0x26B2C20
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x26B2C30 Offset: 0x26B2D31 VA: 0x26B2C30
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C40 Offset: 0x26B2D41 VA: 0x26B2C40
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x26B2C60 Offset: 0x26B2D61 VA: 0x26B2C60
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C80 Offset: 0x26B2D81 VA: 0x26B2C80
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C90 Offset: 0x26B2D91 VA: 0x26B2C90
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x26B2CA0 Offset: 0x26B2DA1 VA: 0x26B2CA0
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x26B2CB0 Offset: 0x26B2DB1 VA: 0x26B2CB0
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x26B2CC0 Offset: 0x26B2DC1 VA: 0x26B2CC0
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x26B2CD0 Offset: 0x26B2DD1 VA: 0x26B2CD0
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x26B2CE0 Offset: 0x26B2DE1 VA: 0x26B2CE0
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x26B2CF0 Offset: 0x26B2DF1 VA: 0x26B2CF0
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x26B2D00 Offset: 0x26B2E01 VA: 0x26B2D00
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x26B2D10 Offset: 0x26B2E11 VA: 0x26B2D10
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x26B2D20 Offset: 0x26B2E21 VA: 0x26B2D20
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

public static class NpadJoy // TypeDefIndex: 11575
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x26B2C10 Offset: 0x26B2D11 VA: 0x26B2C10
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x26B2C20 Offset: 0x26B2D21 VA: 0x26B2C20
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x26B2C30 Offset: 0x26B2D31 VA: 0x26B2C30
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C40 Offset: 0x26B2D41 VA: 0x26B2C40
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x26B2C60 Offset: 0x26B2D61 VA: 0x26B2C60
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C80 Offset: 0x26B2D81 VA: 0x26B2C80
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C90 Offset: 0x26B2D91 VA: 0x26B2C90
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x26B2CA0 Offset: 0x26B2DA1 VA: 0x26B2CA0
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x26B2CB0 Offset: 0x26B2DB1 VA: 0x26B2CB0
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x26B2CC0 Offset: 0x26B2DC1 VA: 0x26B2CC0
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x26B2CD0 Offset: 0x26B2DD1 VA: 0x26B2CD0
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x26B2CE0 Offset: 0x26B2DE1 VA: 0x26B2CE0
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x26B2CF0 Offset: 0x26B2DF1 VA: 0x26B2CF0
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x26B2D00 Offset: 0x26B2E01 VA: 0x26B2D00
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x26B2D10 Offset: 0x26B2E11 VA: 0x26B2D10
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x26B2D20 Offset: 0x26B2E21 VA: 0x26B2D20
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

public static class NpadJoy // TypeDefIndex: 11575
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x26B2C10 Offset: 0x26B2D11 VA: 0x26B2C10
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x26B2C20 Offset: 0x26B2D21 VA: 0x26B2C20
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x26B2C30 Offset: 0x26B2D31 VA: 0x26B2C30
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C40 Offset: 0x26B2D41 VA: 0x26B2C40
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x26B2C60 Offset: 0x26B2D61 VA: 0x26B2C60
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C80 Offset: 0x26B2D81 VA: 0x26B2C80
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C90 Offset: 0x26B2D91 VA: 0x26B2C90
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x26B2CA0 Offset: 0x26B2DA1 VA: 0x26B2CA0
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x26B2CB0 Offset: 0x26B2DB1 VA: 0x26B2CB0
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x26B2CC0 Offset: 0x26B2DC1 VA: 0x26B2CC0
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x26B2CD0 Offset: 0x26B2DD1 VA: 0x26B2CD0
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x26B2CE0 Offset: 0x26B2DE1 VA: 0x26B2CE0
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x26B2CF0 Offset: 0x26B2DF1 VA: 0x26B2CF0
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x26B2D00 Offset: 0x26B2E01 VA: 0x26B2D00
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x26B2D10 Offset: 0x26B2E11 VA: 0x26B2D10
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x26B2D20 Offset: 0x26B2E21 VA: 0x26B2D20
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

public static class NpadJoy // TypeDefIndex: 11575
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x26B2C10 Offset: 0x26B2D11 VA: 0x26B2C10
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x26B2C20 Offset: 0x26B2D21 VA: 0x26B2C20
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x26B2C30 Offset: 0x26B2D31 VA: 0x26B2C30
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C40 Offset: 0x26B2D41 VA: 0x26B2C40
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x26B2C60 Offset: 0x26B2D61 VA: 0x26B2C60
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C80 Offset: 0x26B2D81 VA: 0x26B2C80
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x26B2C90 Offset: 0x26B2D91 VA: 0x26B2C90
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x26B2CA0 Offset: 0x26B2DA1 VA: 0x26B2CA0
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x26B2CB0 Offset: 0x26B2DB1 VA: 0x26B2CB0
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x26B2CC0 Offset: 0x26B2DC1 VA: 0x26B2CC0
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x26B2CD0 Offset: 0x26B2DD1 VA: 0x26B2CD0
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x26B2CE0 Offset: 0x26B2DE1 VA: 0x26B2CE0
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x26B2CF0 Offset: 0x26B2DF1 VA: 0x26B2CF0
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x26B2D00 Offset: 0x26B2E01 VA: 0x26B2D00
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x26B2D10 Offset: 0x26B2E11 VA: 0x26B2D10
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x26B2D20 Offset: 0x26B2E21 VA: 0x26B2D20
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

