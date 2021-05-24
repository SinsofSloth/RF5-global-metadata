public static class Npad // TypeDefIndex: 11563
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x26B1B30 Offset: 0x26B1C31 VA: 0x26B1B30
	public static extern void Initialize() { }

	// RVA: 0x26B1B40 Offset: 0x26B1C41 VA: 0x26B1B40
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x26B1B50 Offset: 0x26B1C51 VA: 0x26B1B50
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x26B1B60 Offset: 0x26B1C61 VA: 0x26B1B60
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x26B1B70 Offset: 0x26B1C71 VA: 0x26B1B70
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x26B1B90 Offset: 0x26B1C91 VA: 0x26B1B90
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BA0 Offset: 0x26B1CA1 VA: 0x26B1BA0
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x26B1BC0 Offset: 0x26B1CC1 VA: 0x26B1BC0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BD0 Offset: 0x26B1CD1 VA: 0x26B1BD0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x26B1BE0 Offset: 0x26B1CE1 VA: 0x26B1BE0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x26B1BF0 Offset: 0x26B1CF1 VA: 0x26B1BF0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x26B1C20 Offset: 0x26B1D21 VA: 0x26B1C20
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x26B1C40 Offset: 0x26B1D41 VA: 0x26B1C40
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B1D30 Offset: 0x26B1E31 VA: 0x26B1D30
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x26B2440 Offset: 0x26B2541 VA: 0x26B2440
	public static ErrorRange get_ResultControllerNotConnected() { }
}

public static class Npad // TypeDefIndex: 11563
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x26B1B30 Offset: 0x26B1C31 VA: 0x26B1B30
	public static extern void Initialize() { }

	// RVA: 0x26B1B40 Offset: 0x26B1C41 VA: 0x26B1B40
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x26B1B50 Offset: 0x26B1C51 VA: 0x26B1B50
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x26B1B60 Offset: 0x26B1C61 VA: 0x26B1B60
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x26B1B70 Offset: 0x26B1C71 VA: 0x26B1B70
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x26B1B90 Offset: 0x26B1C91 VA: 0x26B1B90
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BA0 Offset: 0x26B1CA1 VA: 0x26B1BA0
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x26B1BC0 Offset: 0x26B1CC1 VA: 0x26B1BC0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BD0 Offset: 0x26B1CD1 VA: 0x26B1BD0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x26B1BE0 Offset: 0x26B1CE1 VA: 0x26B1BE0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x26B1BF0 Offset: 0x26B1CF1 VA: 0x26B1BF0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x26B1C20 Offset: 0x26B1D21 VA: 0x26B1C20
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x26B1C40 Offset: 0x26B1D41 VA: 0x26B1C40
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B1D30 Offset: 0x26B1E31 VA: 0x26B1D30
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x26B2440 Offset: 0x26B2541 VA: 0x26B2440
	public static ErrorRange get_ResultControllerNotConnected() { }
}

public static class Npad // TypeDefIndex: 11563
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x26B1B30 Offset: 0x26B1C31 VA: 0x26B1B30
	public static extern void Initialize() { }

	// RVA: 0x26B1B40 Offset: 0x26B1C41 VA: 0x26B1B40
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x26B1B50 Offset: 0x26B1C51 VA: 0x26B1B50
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x26B1B60 Offset: 0x26B1C61 VA: 0x26B1B60
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x26B1B70 Offset: 0x26B1C71 VA: 0x26B1B70
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x26B1B90 Offset: 0x26B1C91 VA: 0x26B1B90
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BA0 Offset: 0x26B1CA1 VA: 0x26B1BA0
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x26B1BC0 Offset: 0x26B1CC1 VA: 0x26B1BC0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BD0 Offset: 0x26B1CD1 VA: 0x26B1BD0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x26B1BE0 Offset: 0x26B1CE1 VA: 0x26B1BE0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x26B1BF0 Offset: 0x26B1CF1 VA: 0x26B1BF0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x26B1C20 Offset: 0x26B1D21 VA: 0x26B1C20
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x26B1C40 Offset: 0x26B1D41 VA: 0x26B1C40
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B1D30 Offset: 0x26B1E31 VA: 0x26B1D30
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x26B2440 Offset: 0x26B2541 VA: 0x26B2440
	public static ErrorRange get_ResultControllerNotConnected() { }
}

public static class Npad // TypeDefIndex: 11563
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x26B1B30 Offset: 0x26B1C31 VA: 0x26B1B30
	public static extern void Initialize() { }

	// RVA: 0x26B1B40 Offset: 0x26B1C41 VA: 0x26B1B40
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x26B1B50 Offset: 0x26B1C51 VA: 0x26B1B50
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x26B1B60 Offset: 0x26B1C61 VA: 0x26B1B60
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x26B1B70 Offset: 0x26B1C71 VA: 0x26B1B70
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x26B1B90 Offset: 0x26B1C91 VA: 0x26B1B90
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BA0 Offset: 0x26B1CA1 VA: 0x26B1BA0
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x26B1BC0 Offset: 0x26B1CC1 VA: 0x26B1BC0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BD0 Offset: 0x26B1CD1 VA: 0x26B1BD0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x26B1BE0 Offset: 0x26B1CE1 VA: 0x26B1BE0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x26B1BF0 Offset: 0x26B1CF1 VA: 0x26B1BF0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x26B1C20 Offset: 0x26B1D21 VA: 0x26B1C20
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x26B1C40 Offset: 0x26B1D41 VA: 0x26B1C40
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B1D30 Offset: 0x26B1E31 VA: 0x26B1D30
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x26B2440 Offset: 0x26B2541 VA: 0x26B2440
	public static ErrorRange get_ResultControllerNotConnected() { }
}

public static class Npad // TypeDefIndex: 11563
{
	// Fields
	public const int StateCountMax = 16;

	// Properties
	public static ErrorRange ResultColorNotAvailable { get; }
	public static ErrorRange ResultControllerNotConnected { get; }

	// Methods

	// RVA: 0x26B1B30 Offset: 0x26B1C31 VA: 0x26B1B30
	public static extern void Initialize() { }

	// RVA: 0x26B1B40 Offset: 0x26B1C41 VA: 0x26B1B40
	public static extern void SetSupportedStyleSet(NpadStyle npadStyle) { }

	// RVA: 0x26B1B50 Offset: 0x26B1C51 VA: 0x26B1B50
	public static extern NpadStyle GetSupportedStyleSet() { }

	// RVA: 0x26B1B60 Offset: 0x26B1C61 VA: 0x26B1B60
	public static extern void SetSupportedIdType(NpadId[] npadIds, long count) { }

	// RVA: 0x26B1B70 Offset: 0x26B1C71 VA: 0x26B1B70
	public static void SetSupportedIdType(NpadId[] npadIds) { }

	// RVA: 0x26B1B90 Offset: 0x26B1C91 VA: 0x26B1B90
	public static extern void BindStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BA0 Offset: 0x26B1CA1 VA: 0x26B1BA0
	public static extern bool IsStyleSetUpdated(NpadId npadId) { }

	// RVA: 0x26B1BC0 Offset: 0x26B1CC1 VA: 0x26B1BC0
	public static extern void DestroyStyleSetUpdateEvent(NpadId npadId) { }

	// RVA: 0x26B1BD0 Offset: 0x26B1CD1 VA: 0x26B1BD0
	public static extern NpadStyle GetStyleSet(NpadId npadId) { }

	// RVA: 0x26B1BE0 Offset: 0x26B1CE1 VA: 0x26B1BE0
	public static extern void Disconnect(NpadId npadId) { }

	// RVA: 0x26B1BF0 Offset: 0x26B1CF1 VA: 0x26B1BF0
	public static extern byte GetPlayerLedPattern(NpadId npadId) { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId) { }

	// RVA: 0x26B1C20 Offset: 0x26B1D21 VA: 0x26B1C20
	public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId) { }

	// RVA: 0x26B1C40 Offset: 0x26B1D41 VA: 0x26B1C40
	public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B1D30 Offset: 0x26B1E31 VA: 0x26B1D30
	public static int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static ErrorRange get_ResultColorNotAvailable() { }

	// RVA: 0x26B2440 Offset: 0x26B2541 VA: 0x26B2440
	public static ErrorRange get_ResultControllerNotConnected() { }
}

