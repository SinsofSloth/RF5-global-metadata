[StaticAccessorAttribute] // RVA: 0xF47A0 Offset: 0xF48A1 VA: 0xF47A0
[NativeHeaderAttribute] // RVA: 0xF47A0 Offset: 0xF48A1 VA: 0xF47A0
public sealed class Event // TypeDefIndex: 3583
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0xF7F40 Offset: 0xF8041 VA: 0xF7F40
	public EventType rawType { get; }
	[NativePropertyAttribute] // RVA: 0xF7F80 Offset: 0xF8081 VA: 0xF7F80
	public Vector2 mousePosition { get; set; }
	[NativePropertyAttribute] // RVA: 0xF7FC0 Offset: 0xF80C1 VA: 0xF7FC0
	public Vector2 delta { get; }
	[NativePropertyAttribute] // RVA: 0xF8000 Offset: 0xF8101 VA: 0xF8000
	public PointerType pointerType { get; }
	[NativePropertyAttribute] // RVA: 0xF8040 Offset: 0xF8141 VA: 0xF8040
	public int button { get; }
	[NativePropertyAttribute] // RVA: 0xF8080 Offset: 0xF8181 VA: 0xF8080
	public EventModifiers modifiers { get; set; }
	[NativePropertyAttribute] // RVA: 0xF80C0 Offset: 0xF81C1 VA: 0xF80C0
	public float pressure { get; }
	[NativePropertyAttribute] // RVA: 0xF8100 Offset: 0xF8201 VA: 0xF8100
	public int clickCount { get; }
	[NativePropertyAttribute] // RVA: 0xF8140 Offset: 0xF8241 VA: 0xF8140
	public char character { get; set; }
	[NativePropertyAttribute] // RVA: 0xF8180 Offset: 0xF8281 VA: 0xF8180
	public KeyCode keyCode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF81C0 Offset: 0xF82C1 VA: 0xF81C0
	public int displayIndex { get; set; }
	public EventType type { get; set; }
	public string commandName { get; set; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; set; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x2CFEFA0 Offset: 0x2CFF0A1 VA: 0x2CFEFA0
	public EventType get_rawType() { }

	// RVA: 0x2CFEFF0 Offset: 0x2CFF0F1 VA: 0x2CFEFF0
	public Vector2 get_mousePosition() { }

	// RVA: 0x2CFF0A0 Offset: 0x2CFF1A1 VA: 0x2CFF0A0
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x2CFF150 Offset: 0x2CFF251 VA: 0x2CFF150
	public Vector2 get_delta() { }

	// RVA: 0x2CFF200 Offset: 0x2CFF301 VA: 0x2CFF200
	public PointerType get_pointerType() { }

	// RVA: 0x2CFF250 Offset: 0x2CFF351 VA: 0x2CFF250
	public int get_button() { }

	// RVA: 0x2CFF2A0 Offset: 0x2CFF3A1 VA: 0x2CFF2A0
	public EventModifiers get_modifiers() { }

	// RVA: 0x2CFF2F0 Offset: 0x2CFF3F1 VA: 0x2CFF2F0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x2CFF340 Offset: 0x2CFF441 VA: 0x2CFF340
	public float get_pressure() { }

	// RVA: 0x2CFF390 Offset: 0x2CFF491 VA: 0x2CFF390
	public int get_clickCount() { }

	// RVA: 0x2CFF3E0 Offset: 0x2CFF4E1 VA: 0x2CFF3E0
	public char get_character() { }

	// RVA: 0x2CFF430 Offset: 0x2CFF531 VA: 0x2CFF430
	public void set_character(char value) { }

	// RVA: 0x2CFF480 Offset: 0x2CFF581 VA: 0x2CFF480
	public KeyCode get_keyCode() { }

	// RVA: 0x2CFF4D0 Offset: 0x2CFF5D1 VA: 0x2CFF4D0
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x2CFF520 Offset: 0x2CFF621 VA: 0x2CFF520
	public int get_displayIndex() { }

	// RVA: 0x2CFF570 Offset: 0x2CFF671 VA: 0x2CFF570
	public void set_displayIndex(int value) { }

	[FreeFunctionAttribute] // RVA: 0xF5E60 Offset: 0xF5F61 VA: 0xF5E60
	// RVA: 0x2CFF5C0 Offset: 0x2CFF6C1 VA: 0x2CFF5C0
	public EventType get_type() { }

	[FreeFunctionAttribute] // RVA: 0xF5EB0 Offset: 0xF5FB1 VA: 0xF5EB0
	// RVA: 0x2CFF610 Offset: 0x2CFF711 VA: 0x2CFF610
	public void set_type(EventType value) { }

	[FreeFunctionAttribute] // RVA: 0xF5F00 Offset: 0xF6001 VA: 0xF5F00
	// RVA: 0x2CFF660 Offset: 0x2CFF761 VA: 0x2CFF660
	public string get_commandName() { }

	[FreeFunctionAttribute] // RVA: 0xF5F50 Offset: 0xF6051 VA: 0xF5F50
	// RVA: 0x2CFF6B0 Offset: 0x2CFF7B1 VA: 0x2CFF6B0
	public void set_commandName(string value) { }

	[NativeMethodAttribute] // RVA: 0xF5FA0 Offset: 0xF60A1 VA: 0xF5FA0
	// RVA: 0x2CFF700 Offset: 0x2CFF801 VA: 0x2CFF700
	private void Internal_Use() { }

	[FreeFunctionAttribute] // RVA: 0xF5FE0 Offset: 0xF60E1 VA: 0xF5FE0
	// RVA: 0x2CFF750 Offset: 0x2CFF851 VA: 0x2CFF750
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunctionAttribute] // RVA: 0xF6030 Offset: 0xF6131 VA: 0xF6030
	// RVA: 0x2CFF7A0 Offset: 0x2CFF8A1 VA: 0x2CFF7A0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF6080 Offset: 0xF6181 VA: 0xF6080
	// RVA: 0x2CFF7F0 Offset: 0x2CFF8F1 VA: 0x2CFF7F0
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunctionAttribute] // RVA: 0xF60D0 Offset: 0xF61D1 VA: 0xF60D0
	[VisibleToOtherModulesAttribute] // RVA: 0xF60D0 Offset: 0xF61D1 VA: 0xF60D0
	// RVA: 0x2CFF840 Offset: 0x2CFF941 VA: 0x2CFF840
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x2CFF890 Offset: 0x2CFF991 VA: 0x2CFF890
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x2CFF8E0 Offset: 0x2CFF9E1 VA: 0x2CFF8E0
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xF6190 Offset: 0xF6291 VA: 0xF6190
	// RVA: 0x2CFF930 Offset: 0x2CFFA31 VA: 0x2CFF930
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x2CFFAD0 Offset: 0x2CFFBD1 VA: 0x2CFFAD0
	public void .ctor() { }

	// RVA: 0x2CFFA70 Offset: 0x2CFFB71 VA: 0x2CFFA70
	public void .ctor(int displayIndex) { }

	// RVA: 0x2CFFB20 Offset: 0x2CFFC21 VA: 0x2CFFB20 Slot: 1
	protected override void Finalize() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF61A0 Offset: 0xF62A1 VA: 0xF61A0
	// RVA: 0x2CFFC10 Offset: 0x2CFFD11 VA: 0x2CFFC10
	internal void CopyFrom(Event e) { }

	// RVA: 0x2CFFC90 Offset: 0x2CFFD91 VA: 0x2CFFC90
	public bool get_shift() { }

	// RVA: 0x2CFFCE0 Offset: 0x2CFFDE1 VA: 0x2CFFCE0
	public bool get_control() { }

	// RVA: 0x2CFFD30 Offset: 0x2CFFE31 VA: 0x2CFFD30
	public bool get_alt() { }

	// RVA: 0x2CFFD80 Offset: 0x2CFFE81 VA: 0x2CFFD80
	public bool get_command() { }

	// RVA: 0x2CFFDD0 Offset: 0x2CFFED1 VA: 0x2CFFDD0
	public static Event get_current() { }

	// RVA: 0x2CFFE20 Offset: 0x2CFFF21 VA: 0x2CFFE20
	public static void set_current(Event value) { }

	// RVA: 0x2CFFED0 Offset: 0x2CFFFD1 VA: 0x2CFFED0
	public bool get_isKey() { }

	// RVA: 0x2CFFF20 Offset: 0x2D00021 VA: 0x2CFFF20
	public bool get_isMouse() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xF6230 Offset: 0xF6331 VA: 0xF6230
	// RVA: 0x2CFFF90 Offset: 0x2D00091 VA: 0x2CFFF90
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x2D00030 Offset: 0x2D00131 VA: 0x2D00030
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x2D01A30 Offset: 0x2D01B31 VA: 0x2D01A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D01B90 Offset: 0x2D01C91 VA: 0x2D01B90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D01E90 Offset: 0x2D01F91 VA: 0x2D01E90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D027B0 Offset: 0x2D028B1 VA: 0x2D027B0
	public void Use() { }

	// RVA: 0x2CFF050 Offset: 0x2CFF151 VA: 0x2CFF050
	private void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x2CFF100 Offset: 0x2CFF201 VA: 0x2CFF100
	private void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x2CFF1B0 Offset: 0x2CFF2B1 VA: 0x2CFF1B0
	private void get_delta_Injected(out Vector2 ret) { }
}

