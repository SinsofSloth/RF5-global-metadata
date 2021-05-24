public class CinemachineBlend // TypeDefIndex: 4815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134430 Offset: 0x134531 VA: 0x134430
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134440 Offset: 0x134541 VA: 0x134440
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134450 Offset: 0x134551 VA: 0x134450
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134460 Offset: 0x134561 VA: 0x134460
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134470 Offset: 0x134571 VA: 0x134470
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136F60 Offset: 0x137061 VA: 0x136F60
	// RVA: 0x1889060 Offset: 0x1889161 VA: 0x1889060
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F70 Offset: 0x137071 VA: 0x136F70
	// RVA: 0x1889070 Offset: 0x1889171 VA: 0x1889070
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F80 Offset: 0x137081 VA: 0x136F80
	// RVA: 0x1889080 Offset: 0x1889181 VA: 0x1889080
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F90 Offset: 0x137091 VA: 0x136F90
	// RVA: 0x1889090 Offset: 0x1889191 VA: 0x1889090
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FA0 Offset: 0x1370A1 VA: 0x136FA0
	// RVA: 0x18890A0 Offset: 0x18891A1 VA: 0x18890A0
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FB0 Offset: 0x1370B1 VA: 0x136FB0
	// RVA: 0x18890B0 Offset: 0x18891B1 VA: 0x18890B0
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FC0 Offset: 0x1370C1 VA: 0x136FC0
	// RVA: 0x18890C0 Offset: 0x18891C1 VA: 0x18890C0
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FD0 Offset: 0x1370D1 VA: 0x136FD0
	// RVA: 0x18890D0 Offset: 0x18891D1 VA: 0x18890D0
	public void set_TimeInBlend(float value) { }

	// RVA: 0x18890E0 Offset: 0x18891E1 VA: 0x18890E0
	public float get_BlendWeight() { }

	// RVA: 0x18831F0 Offset: 0x18832F1 VA: 0x18831F0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FE0 Offset: 0x1370E1 VA: 0x136FE0
	// RVA: 0x1889200 Offset: 0x1889301 VA: 0x1889200
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FF0 Offset: 0x1370F1 VA: 0x136FF0
	// RVA: 0x1889210 Offset: 0x1889311 VA: 0x1889210
	public void set_Duration(float value) { }

	// RVA: 0x18891C0 Offset: 0x18892C1 VA: 0x18891C0
	public bool get_IsComplete() { }

	// RVA: 0x1882DE0 Offset: 0x1882EE1 VA: 0x1882DE0
	public string get_Description() { }

	// RVA: 0x1889220 Offset: 0x1889321 VA: 0x1889220
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1889380 Offset: 0x1889481 VA: 0x1889380
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1883410 Offset: 0x1883511 VA: 0x1883410
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x18836A0 Offset: 0x18837A1 VA: 0x18836A0
	public CameraState get_State() { }
}

public class CinemachineBlend // TypeDefIndex: 4815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134430 Offset: 0x134531 VA: 0x134430
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134440 Offset: 0x134541 VA: 0x134440
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134450 Offset: 0x134551 VA: 0x134450
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134460 Offset: 0x134561 VA: 0x134460
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134470 Offset: 0x134571 VA: 0x134470
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136F60 Offset: 0x137061 VA: 0x136F60
	// RVA: 0x1889060 Offset: 0x1889161 VA: 0x1889060
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F70 Offset: 0x137071 VA: 0x136F70
	// RVA: 0x1889070 Offset: 0x1889171 VA: 0x1889070
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F80 Offset: 0x137081 VA: 0x136F80
	// RVA: 0x1889080 Offset: 0x1889181 VA: 0x1889080
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F90 Offset: 0x137091 VA: 0x136F90
	// RVA: 0x1889090 Offset: 0x1889191 VA: 0x1889090
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FA0 Offset: 0x1370A1 VA: 0x136FA0
	// RVA: 0x18890A0 Offset: 0x18891A1 VA: 0x18890A0
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FB0 Offset: 0x1370B1 VA: 0x136FB0
	// RVA: 0x18890B0 Offset: 0x18891B1 VA: 0x18890B0
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FC0 Offset: 0x1370C1 VA: 0x136FC0
	// RVA: 0x18890C0 Offset: 0x18891C1 VA: 0x18890C0
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FD0 Offset: 0x1370D1 VA: 0x136FD0
	// RVA: 0x18890D0 Offset: 0x18891D1 VA: 0x18890D0
	public void set_TimeInBlend(float value) { }

	// RVA: 0x18890E0 Offset: 0x18891E1 VA: 0x18890E0
	public float get_BlendWeight() { }

	// RVA: 0x18831F0 Offset: 0x18832F1 VA: 0x18831F0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FE0 Offset: 0x1370E1 VA: 0x136FE0
	// RVA: 0x1889200 Offset: 0x1889301 VA: 0x1889200
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FF0 Offset: 0x1370F1 VA: 0x136FF0
	// RVA: 0x1889210 Offset: 0x1889311 VA: 0x1889210
	public void set_Duration(float value) { }

	// RVA: 0x18891C0 Offset: 0x18892C1 VA: 0x18891C0
	public bool get_IsComplete() { }

	// RVA: 0x1882DE0 Offset: 0x1882EE1 VA: 0x1882DE0
	public string get_Description() { }

	// RVA: 0x1889220 Offset: 0x1889321 VA: 0x1889220
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1889380 Offset: 0x1889481 VA: 0x1889380
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1883410 Offset: 0x1883511 VA: 0x1883410
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x18836A0 Offset: 0x18837A1 VA: 0x18836A0
	public CameraState get_State() { }
}

public class CinemachineBlend // TypeDefIndex: 4815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134430 Offset: 0x134531 VA: 0x134430
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134440 Offset: 0x134541 VA: 0x134440
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134450 Offset: 0x134551 VA: 0x134450
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134460 Offset: 0x134561 VA: 0x134460
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134470 Offset: 0x134571 VA: 0x134470
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136F60 Offset: 0x137061 VA: 0x136F60
	// RVA: 0x1889060 Offset: 0x1889161 VA: 0x1889060
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F70 Offset: 0x137071 VA: 0x136F70
	// RVA: 0x1889070 Offset: 0x1889171 VA: 0x1889070
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F80 Offset: 0x137081 VA: 0x136F80
	// RVA: 0x1889080 Offset: 0x1889181 VA: 0x1889080
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F90 Offset: 0x137091 VA: 0x136F90
	// RVA: 0x1889090 Offset: 0x1889191 VA: 0x1889090
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FA0 Offset: 0x1370A1 VA: 0x136FA0
	// RVA: 0x18890A0 Offset: 0x18891A1 VA: 0x18890A0
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FB0 Offset: 0x1370B1 VA: 0x136FB0
	// RVA: 0x18890B0 Offset: 0x18891B1 VA: 0x18890B0
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FC0 Offset: 0x1370C1 VA: 0x136FC0
	// RVA: 0x18890C0 Offset: 0x18891C1 VA: 0x18890C0
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FD0 Offset: 0x1370D1 VA: 0x136FD0
	// RVA: 0x18890D0 Offset: 0x18891D1 VA: 0x18890D0
	public void set_TimeInBlend(float value) { }

	// RVA: 0x18890E0 Offset: 0x18891E1 VA: 0x18890E0
	public float get_BlendWeight() { }

	// RVA: 0x18831F0 Offset: 0x18832F1 VA: 0x18831F0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FE0 Offset: 0x1370E1 VA: 0x136FE0
	// RVA: 0x1889200 Offset: 0x1889301 VA: 0x1889200
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FF0 Offset: 0x1370F1 VA: 0x136FF0
	// RVA: 0x1889210 Offset: 0x1889311 VA: 0x1889210
	public void set_Duration(float value) { }

	// RVA: 0x18891C0 Offset: 0x18892C1 VA: 0x18891C0
	public bool get_IsComplete() { }

	// RVA: 0x1882DE0 Offset: 0x1882EE1 VA: 0x1882DE0
	public string get_Description() { }

	// RVA: 0x1889220 Offset: 0x1889321 VA: 0x1889220
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1889380 Offset: 0x1889481 VA: 0x1889380
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1883410 Offset: 0x1883511 VA: 0x1883410
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x18836A0 Offset: 0x18837A1 VA: 0x18836A0
	public CameraState get_State() { }
}

public class CinemachineBlend // TypeDefIndex: 4815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134430 Offset: 0x134531 VA: 0x134430
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134440 Offset: 0x134541 VA: 0x134440
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134450 Offset: 0x134551 VA: 0x134450
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134460 Offset: 0x134561 VA: 0x134460
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134470 Offset: 0x134571 VA: 0x134470
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136F60 Offset: 0x137061 VA: 0x136F60
	// RVA: 0x1889060 Offset: 0x1889161 VA: 0x1889060
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F70 Offset: 0x137071 VA: 0x136F70
	// RVA: 0x1889070 Offset: 0x1889171 VA: 0x1889070
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F80 Offset: 0x137081 VA: 0x136F80
	// RVA: 0x1889080 Offset: 0x1889181 VA: 0x1889080
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F90 Offset: 0x137091 VA: 0x136F90
	// RVA: 0x1889090 Offset: 0x1889191 VA: 0x1889090
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FA0 Offset: 0x1370A1 VA: 0x136FA0
	// RVA: 0x18890A0 Offset: 0x18891A1 VA: 0x18890A0
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FB0 Offset: 0x1370B1 VA: 0x136FB0
	// RVA: 0x18890B0 Offset: 0x18891B1 VA: 0x18890B0
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FC0 Offset: 0x1370C1 VA: 0x136FC0
	// RVA: 0x18890C0 Offset: 0x18891C1 VA: 0x18890C0
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FD0 Offset: 0x1370D1 VA: 0x136FD0
	// RVA: 0x18890D0 Offset: 0x18891D1 VA: 0x18890D0
	public void set_TimeInBlend(float value) { }

	// RVA: 0x18890E0 Offset: 0x18891E1 VA: 0x18890E0
	public float get_BlendWeight() { }

	// RVA: 0x18831F0 Offset: 0x18832F1 VA: 0x18831F0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FE0 Offset: 0x1370E1 VA: 0x136FE0
	// RVA: 0x1889200 Offset: 0x1889301 VA: 0x1889200
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FF0 Offset: 0x1370F1 VA: 0x136FF0
	// RVA: 0x1889210 Offset: 0x1889311 VA: 0x1889210
	public void set_Duration(float value) { }

	// RVA: 0x18891C0 Offset: 0x18892C1 VA: 0x18891C0
	public bool get_IsComplete() { }

	// RVA: 0x1882DE0 Offset: 0x1882EE1 VA: 0x1882DE0
	public string get_Description() { }

	// RVA: 0x1889220 Offset: 0x1889321 VA: 0x1889220
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1889380 Offset: 0x1889481 VA: 0x1889380
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1883410 Offset: 0x1883511 VA: 0x1883410
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x18836A0 Offset: 0x18837A1 VA: 0x18836A0
	public CameraState get_State() { }
}

public class CinemachineBlend // TypeDefIndex: 4815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134430 Offset: 0x134531 VA: 0x134430
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134440 Offset: 0x134541 VA: 0x134440
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134450 Offset: 0x134551 VA: 0x134450
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134460 Offset: 0x134561 VA: 0x134460
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134470 Offset: 0x134571 VA: 0x134470
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136F60 Offset: 0x137061 VA: 0x136F60
	// RVA: 0x1889060 Offset: 0x1889161 VA: 0x1889060
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F70 Offset: 0x137071 VA: 0x136F70
	// RVA: 0x1889070 Offset: 0x1889171 VA: 0x1889070
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F80 Offset: 0x137081 VA: 0x136F80
	// RVA: 0x1889080 Offset: 0x1889181 VA: 0x1889080
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F90 Offset: 0x137091 VA: 0x136F90
	// RVA: 0x1889090 Offset: 0x1889191 VA: 0x1889090
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FA0 Offset: 0x1370A1 VA: 0x136FA0
	// RVA: 0x18890A0 Offset: 0x18891A1 VA: 0x18890A0
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FB0 Offset: 0x1370B1 VA: 0x136FB0
	// RVA: 0x18890B0 Offset: 0x18891B1 VA: 0x18890B0
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136FC0 Offset: 0x1370C1 VA: 0x136FC0
	// RVA: 0x18890C0 Offset: 0x18891C1 VA: 0x18890C0
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FD0 Offset: 0x1370D1 VA: 0x136FD0
	// RVA: 0x18890D0 Offset: 0x18891D1 VA: 0x18890D0
	public void set_TimeInBlend(float value) { }

	// RVA: 0x18890E0 Offset: 0x18891E1 VA: 0x18890E0
	public float get_BlendWeight() { }

	// RVA: 0x18831F0 Offset: 0x18832F1 VA: 0x18831F0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FE0 Offset: 0x1370E1 VA: 0x136FE0
	// RVA: 0x1889200 Offset: 0x1889301 VA: 0x1889200
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x136FF0 Offset: 0x1370F1 VA: 0x136FF0
	// RVA: 0x1889210 Offset: 0x1889311 VA: 0x1889210
	public void set_Duration(float value) { }

	// RVA: 0x18891C0 Offset: 0x18892C1 VA: 0x18891C0
	public bool get_IsComplete() { }

	// RVA: 0x1882DE0 Offset: 0x1882EE1 VA: 0x1882DE0
	public string get_Description() { }

	// RVA: 0x1889220 Offset: 0x1889321 VA: 0x1889220
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1889380 Offset: 0x1889481 VA: 0x1889380
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1883410 Offset: 0x1883511 VA: 0x1883410
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x18836A0 Offset: 0x18837A1 VA: 0x18836A0
	public CameraState get_State() { }
}

