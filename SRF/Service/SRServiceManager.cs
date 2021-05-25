[AddComponentMenu] // RVA: 0x127790 Offset: 0x127891 VA: 0x127790
public class SRServiceManager : SRAutoSingleton<SRServiceManager> // TypeDefIndex: 4353
{
	// Fields
	public const bool EnableLogging = False;
	public static int LoadingCount; // 0x0
	private static readonly List<Assembly> _assemblies; // 0x8
	private readonly SRList<SRServiceManager.Service> _services; // 0x48
	private List<SRServiceManager.ServiceStub> _serviceStubs; // 0x50
	private static bool _hasQuit; // 0x10

	// Properties
	public static bool IsLoading { get; }

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x128340 Offset: 0x128441 VA: 0x128340
	// RVA: 0x1A82180 Offset: 0x1A82281 VA: 0x1A82180
	public static void RuntimeInitialize() { }

	// RVA: -1 Offset: -1
	public static void RegisterAssembly<TType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6E10 Offset: 0x21D6F11 VA: 0x21D6E10
	|-SRServiceManager.RegisterAssembly<IDebugService>
	|-SRServiceManager.RegisterAssembly<SRServiceManager>
	|-SRServiceManager.RegisterAssembly<object>
	*/

	// RVA: 0x1A821F0 Offset: 0x1A822F1 VA: 0x1A821F0
	public static bool get_IsLoading() { }

	// RVA: -1 Offset: -1
	public static T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C7480 Offset: 0x23C7581 VA: 0x23C7480
	|-SRServiceManager.GetService<InternalOptionsRegistry>
	|-SRServiceManager.GetService<IBugReportService>
	|-SRServiceManager.GetService<IConsoleService>
	|-SRServiceManager.GetService<IDebugCameraService>
	|-SRServiceManager.GetService<IDebugPanelService>
	|-SRServiceManager.GetService<IDebugService>
	|-SRServiceManager.GetService<IDebugTriggerService>
	|-SRServiceManager.GetService<IDockConsoleService>
	|-SRServiceManager.GetService<IOptionsService>
	|-SRServiceManager.GetService<IPinEntryService>
	|-SRServiceManager.GetService<IPinnedUIService>
	|-SRServiceManager.GetService<IProfilerService>
	|-SRServiceManager.GetService<ISystemInformationService>
	|-SRServiceManager.GetService<BugReportPopoverService>
	|-SRServiceManager.GetService<KeyboardShortcutListenerService>
	|-SRServiceManager.GetService<object>
	*/

	// RVA: 0x1A81EF0 Offset: 0x1A81FF1 VA: 0x1A81EF0
	public static object GetService(Type t) { }

	// RVA: 0x1A82260 Offset: 0x1A82361 VA: 0x1A82260
	private static object GetServiceInternal(Type t) { }

	// RVA: -1 Offset: -1
	public static bool HasService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519D30 Offset: 0x2519E31 VA: 0x2519D30
	|-SRServiceManager.HasService<object>
	*/

	// RVA: 0x1A82880 Offset: 0x1A82981 VA: 0x1A82880
	public static bool HasService(Type t) { }

	// RVA: -1 Offset: -1
	public static void RegisterService<T>(object service) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6F30 Offset: 0x21D7031 VA: 0x21D6F30
	|-SRServiceManager.RegisterService<IConsoleService>
	|-SRServiceManager.RegisterService<IDebugService>
	|-SRServiceManager.RegisterService<object>
	*/

	// RVA: 0x1A829D0 Offset: 0x1A82AD1 VA: 0x1A829D0
	private static void RegisterService(Type t, object service) { }

	// RVA: -1 Offset: -1
	public static void UnRegisterService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6FE0 Offset: 0x21D70E1 VA: 0x21D6FE0
	|-SRServiceManager.UnRegisterService<object>
	*/

	// RVA: 0x1A82410 Offset: 0x1A82511 VA: 0x1A82410
	private static void UnRegisterService(Type t) { }

	// RVA: 0x1A82C90 Offset: 0x1A82D91 VA: 0x1A82C90 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A82E50 Offset: 0x1A82F51 VA: 0x1A82E50
	protected void UpdateStubs() { }

	// RVA: 0x1A82590 Offset: 0x1A82691 VA: 0x1A82590
	protected object AutoCreateService(Type t) { }

	// RVA: 0x1A83650 Offset: 0x1A83751 VA: 0x1A83650
	protected void OnApplicationQuit() { }

	// RVA: 0x1A834C0 Offset: 0x1A835C1 VA: 0x1A834C0
	private static object DefaultServiceConstructor(Type serviceIntType, Type implType) { }

	// RVA: 0x1A833B0 Offset: 0x1A834B1 VA: 0x1A833B0
	private void ScanType(Type type) { }

	// RVA: 0x1A83BA0 Offset: 0x1A83CA1 VA: 0x1A83BA0
	private static void ScanTypeForSelectors(Type t, List<SRServiceManager.ServiceStub> stubs) { }

	// RVA: 0x1A836D0 Offset: 0x1A837D1 VA: 0x1A836D0
	private static void ScanTypeForConstructors(Type t, List<SRServiceManager.ServiceStub> stubs) { }

	// RVA: 0x1A84060 Offset: 0x1A84161 VA: 0x1A84060
	private static MethodInfo[] GetStaticMethods(Type t) { }

	// RVA: 0x1A840B0 Offset: 0x1A841B1 VA: 0x1A840B0
	public void .ctor() { }

	// RVA: 0x1A84140 Offset: 0x1A84241 VA: 0x1A84140
	private static void .cctor() { }
}

