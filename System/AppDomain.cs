[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

[ClassInterfaceAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
[ComVisibleAttribute] // RVA: 0xACC70 Offset: 0xACD71 VA: 0xACC70
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 347
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB4400 Offset: 0xB4501 VA: 0xB4400
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4410 Offset: 0xB4511 VA: 0xB4410
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0xB4420 Offset: 0xB4521 VA: 0xB4420
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0xB4430 Offset: 0xB4531 VA: 0xB4430
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xB4440 Offset: 0xB4541 VA: 0xB4440
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xB4450 Offset: 0xB4551 VA: 0xB4450
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xB4460 Offset: 0xB4561 VA: 0xB4460
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xB4470 Offset: 0xB4571 VA: 0xB4470
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xB4480 Offset: 0xB4581 VA: 0xB4480
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xB4490 Offset: 0xB4591 VA: 0xB4490
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB44A0 Offset: 0xB45A1 VA: 0xB44A0
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB44B0 Offset: 0xB45B1 VA: 0xB44B0
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0xB44C0 Offset: 0xB45C1 VA: 0xB44C0
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x1846330 Offset: 0x1846431 VA: 0x1846330
	private void .ctor() { }

	// RVA: 0x1846340 Offset: 0x1846441 VA: 0x1846340
	private string getFriendlyName() { }

	// RVA: 0x1846350 Offset: 0x1846451 VA: 0x1846350
	private static AppDomain getCurDomain() { }

	// RVA: 0x1846360 Offset: 0x1846461 VA: 0x1846360
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1846370 Offset: 0x1846471 VA: 0x1846370
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1846380 Offset: 0x1846481 VA: 0x1846380 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1846390 Offset: 0x1846491 VA: 0x1846390 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x18463A0 Offset: 0x18464A1 VA: 0x18463A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x18463B0 Offset: 0x18464B1 VA: 0x18463B0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x18463C0 Offset: 0x18464C1 VA: 0x18463C0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	// RVA: 0x1846580 Offset: 0x1846681 VA: 0x1846580 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1846590 Offset: 0x1846691 VA: 0x1846590
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x1846700 Offset: 0x1846801 VA: 0x1846700
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1846710 Offset: 0x1846811 VA: 0x1846710
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1846720 Offset: 0x1846821 VA: 0x1846720
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1846730 Offset: 0x1846831 VA: 0x1846730
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1846740 Offset: 0x1846841 VA: 0x1846740
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1846750 Offset: 0x1846851 VA: 0x1846750
	internal static Context InternalGetContext() { }

	// RVA: 0x1846760 Offset: 0x1846861 VA: 0x1846760
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1846770 Offset: 0x1846871 VA: 0x1846770
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1846780 Offset: 0x1846881 VA: 0x1846780
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1846910 Offset: 0x1846A11 VA: 0x1846910
	internal static string GetProcessGuid() { }

	// RVA: 0x18469E0 Offset: 0x1846AE1 VA: 0x18469E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x18469F0 Offset: 0x1846AF1 VA: 0x18469F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1846A10 Offset: 0x1846B11 VA: 0x1846A10
	private int getDomainID() { }

	// RVA: 0x1846A20 Offset: 0x1846B21 VA: 0x1846A20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1846A30 Offset: 0x1846B31 VA: 0x1846A30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1846FD0 Offset: 0x18470D1 VA: 0x1846FD0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x18472B0 Offset: 0x18473B1 VA: 0x18472B0
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x1847550 Offset: 0x1847651 VA: 0x1847550
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1847680 Offset: 0x1847781 VA: 0x1847680
	private void DoDomainUnload() { }

	// RVA: 0x18476A0 Offset: 0x18477A1 VA: 0x18476A0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1847770 Offset: 0x1847871 VA: 0x1847770
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7120 Offset: 0xB7221 VA: 0xB7120
	// RVA: 0x18478C0 Offset: 0x18479C1 VA: 0x18478C0 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7130 Offset: 0xB7231 VA: 0xB7130
	// RVA: 0x1847970 Offset: 0x1847A71 VA: 0x1847970 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7140 Offset: 0xB7241 VA: 0xB7140
	// RVA: 0x1847A20 Offset: 0x1847B21 VA: 0x1847A20 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB7150 Offset: 0xB7251 VA: 0xB7150
	// RVA: 0x1847AD0 Offset: 0x1847BD1 VA: 0x1847AD0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

