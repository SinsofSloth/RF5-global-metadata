public class UIDualWork : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	[SerializeField] // RVA: 0x181760 Offset: 0x181861 VA: 0x181760
	private Image SynchroGauge; // 0x18
	[SerializeField] // RVA: 0x181770 Offset: 0x181871 VA: 0x181770
	private RectTransform SynchroNorma; // 0x20
	[SerializeField] // RVA: 0x181780 Offset: 0x181881 VA: 0x181780
	private RectTransform SynchroKirakira; // 0x28
	[SerializeField] // RVA: 0x181790 Offset: 0x181891 VA: 0x181790
	private Image SuccessGauge; // 0x30
	[SerializeField] // RVA: 0x1817A0 Offset: 0x1818A1 VA: 0x1817A0
	private Image CriticalGauge; // 0x38
	[SerializeField] // RVA: 0x1817B0 Offset: 0x1818B1 VA: 0x1817B0
	private RectTransform TimingBar; // 0x40
	[SerializeField] // RVA: 0x1817C0 Offset: 0x1818C1 VA: 0x1817C0
	private RectTransform TimingGauge; // 0x48
	[SerializeField] // RVA: 0x1817D0 Offset: 0x1818D1 VA: 0x1817D0
	private GameObject PerfectImpact; // 0x50
	[SerializeField] // RVA: 0x1817E0 Offset: 0x1818E1 VA: 0x1817E0
	private GameObject NiceImpact; // 0x58
	[SerializeField] // RVA: 0x1817F0 Offset: 0x1818F1 VA: 0x1817F0
	private GameObject BadImpact; // 0x60
	[SerializeField] // RVA: 0x181800 Offset: 0x181901 VA: 0x181800
	private Image PerfectImage; // 0x68
	[SerializeField] // RVA: 0x181810 Offset: 0x181911 VA: 0x181810
	private Image NiceImage; // 0x70
	[SerializeField] // RVA: 0x181820 Offset: 0x181921 VA: 0x181820
	private Image BadImage; // 0x78
	[SerializeField] // RVA: 0x181830 Offset: 0x181931 VA: 0x181830
	private FestivalNumScore TimerUI; // 0x80
	[SerializeField] // RVA: 0x181840 Offset: 0x181941 VA: 0x181840
	private Image FadeImage; // 0x88
	private Coroutine PrevCoroutine; // 0x90

	// Methods

	// RVA: 0x200CE50 Offset: 0x200CF51 VA: 0x200CE50
	public void SetSynchroGauge(float gauge) { }

	// RVA: 0x200CFD0 Offset: 0x200D0D1 VA: 0x200CFD0
	public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition) { }

	// RVA: 0x200D1D0 Offset: 0x200D2D1 VA: 0x200D1D0
	public void Init() { }

	// RVA: 0x200D270 Offset: 0x200D371 VA: 0x200D270
	public void SetPosTimingbar(float position) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF0D0 Offset: 0x1AF1D1 VA: 0x1AF0D0
	// RVA: 0x200D390 Offset: 0x200D491 VA: 0x200D390
	private IEnumerator FadeBarImpactEffect(GameObject gameObject) { }

	// RVA: 0x200D460 Offset: 0x200D561 VA: 0x200D460
	public void OnPerfect() { }

	// RVA: 0x200D640 Offset: 0x200D741 VA: 0x200D640
	public void OnNice() { }

	// RVA: 0x200D7A0 Offset: 0x200D8A1 VA: 0x200D7A0
	public void OnBad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF140 Offset: 0x1AF241 VA: 0x1AF140
	// RVA: 0x200D5C0 Offset: 0x200D6C1 VA: 0x200D5C0
	private IEnumerator DelayDisable(Image image) { }

	// RVA: 0x200D930 Offset: 0x200DA31 VA: 0x200D930
	public void UpdateTimeText(float time) { }

	// RVA: 0x200D950 Offset: 0x200DA51 VA: 0x200D950
	public void BlackFadeScreen(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF1B0 Offset: 0x1AF2B1 VA: 0x1AF1B0
	// RVA: 0x200DA10 Offset: 0x200DB11 VA: 0x200DA10
	private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback) { }

	// RVA: 0x200DB00 Offset: 0x200DC01 VA: 0x200DB00
	public void .ctor() { }
}

public class UIDualWork : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	[SerializeField] // RVA: 0x181760 Offset: 0x181861 VA: 0x181760
	private Image SynchroGauge; // 0x18
	[SerializeField] // RVA: 0x181770 Offset: 0x181871 VA: 0x181770
	private RectTransform SynchroNorma; // 0x20
	[SerializeField] // RVA: 0x181780 Offset: 0x181881 VA: 0x181780
	private RectTransform SynchroKirakira; // 0x28
	[SerializeField] // RVA: 0x181790 Offset: 0x181891 VA: 0x181790
	private Image SuccessGauge; // 0x30
	[SerializeField] // RVA: 0x1817A0 Offset: 0x1818A1 VA: 0x1817A0
	private Image CriticalGauge; // 0x38
	[SerializeField] // RVA: 0x1817B0 Offset: 0x1818B1 VA: 0x1817B0
	private RectTransform TimingBar; // 0x40
	[SerializeField] // RVA: 0x1817C0 Offset: 0x1818C1 VA: 0x1817C0
	private RectTransform TimingGauge; // 0x48
	[SerializeField] // RVA: 0x1817D0 Offset: 0x1818D1 VA: 0x1817D0
	private GameObject PerfectImpact; // 0x50
	[SerializeField] // RVA: 0x1817E0 Offset: 0x1818E1 VA: 0x1817E0
	private GameObject NiceImpact; // 0x58
	[SerializeField] // RVA: 0x1817F0 Offset: 0x1818F1 VA: 0x1817F0
	private GameObject BadImpact; // 0x60
	[SerializeField] // RVA: 0x181800 Offset: 0x181901 VA: 0x181800
	private Image PerfectImage; // 0x68
	[SerializeField] // RVA: 0x181810 Offset: 0x181911 VA: 0x181810
	private Image NiceImage; // 0x70
	[SerializeField] // RVA: 0x181820 Offset: 0x181921 VA: 0x181820
	private Image BadImage; // 0x78
	[SerializeField] // RVA: 0x181830 Offset: 0x181931 VA: 0x181830
	private FestivalNumScore TimerUI; // 0x80
	[SerializeField] // RVA: 0x181840 Offset: 0x181941 VA: 0x181840
	private Image FadeImage; // 0x88
	private Coroutine PrevCoroutine; // 0x90

	// Methods

	// RVA: 0x200CE50 Offset: 0x200CF51 VA: 0x200CE50
	public void SetSynchroGauge(float gauge) { }

	// RVA: 0x200CFD0 Offset: 0x200D0D1 VA: 0x200CFD0
	public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition) { }

	// RVA: 0x200D1D0 Offset: 0x200D2D1 VA: 0x200D1D0
	public void Init() { }

	// RVA: 0x200D270 Offset: 0x200D371 VA: 0x200D270
	public void SetPosTimingbar(float position) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF0D0 Offset: 0x1AF1D1 VA: 0x1AF0D0
	// RVA: 0x200D390 Offset: 0x200D491 VA: 0x200D390
	private IEnumerator FadeBarImpactEffect(GameObject gameObject) { }

	// RVA: 0x200D460 Offset: 0x200D561 VA: 0x200D460
	public void OnPerfect() { }

	// RVA: 0x200D640 Offset: 0x200D741 VA: 0x200D640
	public void OnNice() { }

	// RVA: 0x200D7A0 Offset: 0x200D8A1 VA: 0x200D7A0
	public void OnBad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF140 Offset: 0x1AF241 VA: 0x1AF140
	// RVA: 0x200D5C0 Offset: 0x200D6C1 VA: 0x200D5C0
	private IEnumerator DelayDisable(Image image) { }

	// RVA: 0x200D930 Offset: 0x200DA31 VA: 0x200D930
	public void UpdateTimeText(float time) { }

	// RVA: 0x200D950 Offset: 0x200DA51 VA: 0x200D950
	public void BlackFadeScreen(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF1B0 Offset: 0x1AF2B1 VA: 0x1AF1B0
	// RVA: 0x200DA10 Offset: 0x200DB11 VA: 0x200DA10
	private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback) { }

	// RVA: 0x200DB00 Offset: 0x200DC01 VA: 0x200DB00
	public void .ctor() { }
}

public class UIDualWork : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	[SerializeField] // RVA: 0x181760 Offset: 0x181861 VA: 0x181760
	private Image SynchroGauge; // 0x18
	[SerializeField] // RVA: 0x181770 Offset: 0x181871 VA: 0x181770
	private RectTransform SynchroNorma; // 0x20
	[SerializeField] // RVA: 0x181780 Offset: 0x181881 VA: 0x181780
	private RectTransform SynchroKirakira; // 0x28
	[SerializeField] // RVA: 0x181790 Offset: 0x181891 VA: 0x181790
	private Image SuccessGauge; // 0x30
	[SerializeField] // RVA: 0x1817A0 Offset: 0x1818A1 VA: 0x1817A0
	private Image CriticalGauge; // 0x38
	[SerializeField] // RVA: 0x1817B0 Offset: 0x1818B1 VA: 0x1817B0
	private RectTransform TimingBar; // 0x40
	[SerializeField] // RVA: 0x1817C0 Offset: 0x1818C1 VA: 0x1817C0
	private RectTransform TimingGauge; // 0x48
	[SerializeField] // RVA: 0x1817D0 Offset: 0x1818D1 VA: 0x1817D0
	private GameObject PerfectImpact; // 0x50
	[SerializeField] // RVA: 0x1817E0 Offset: 0x1818E1 VA: 0x1817E0
	private GameObject NiceImpact; // 0x58
	[SerializeField] // RVA: 0x1817F0 Offset: 0x1818F1 VA: 0x1817F0
	private GameObject BadImpact; // 0x60
	[SerializeField] // RVA: 0x181800 Offset: 0x181901 VA: 0x181800
	private Image PerfectImage; // 0x68
	[SerializeField] // RVA: 0x181810 Offset: 0x181911 VA: 0x181810
	private Image NiceImage; // 0x70
	[SerializeField] // RVA: 0x181820 Offset: 0x181921 VA: 0x181820
	private Image BadImage; // 0x78
	[SerializeField] // RVA: 0x181830 Offset: 0x181931 VA: 0x181830
	private FestivalNumScore TimerUI; // 0x80
	[SerializeField] // RVA: 0x181840 Offset: 0x181941 VA: 0x181840
	private Image FadeImage; // 0x88
	private Coroutine PrevCoroutine; // 0x90

	// Methods

	// RVA: 0x200CE50 Offset: 0x200CF51 VA: 0x200CE50
	public void SetSynchroGauge(float gauge) { }

	// RVA: 0x200CFD0 Offset: 0x200D0D1 VA: 0x200CFD0
	public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition) { }

	// RVA: 0x200D1D0 Offset: 0x200D2D1 VA: 0x200D1D0
	public void Init() { }

	// RVA: 0x200D270 Offset: 0x200D371 VA: 0x200D270
	public void SetPosTimingbar(float position) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF0D0 Offset: 0x1AF1D1 VA: 0x1AF0D0
	// RVA: 0x200D390 Offset: 0x200D491 VA: 0x200D390
	private IEnumerator FadeBarImpactEffect(GameObject gameObject) { }

	// RVA: 0x200D460 Offset: 0x200D561 VA: 0x200D460
	public void OnPerfect() { }

	// RVA: 0x200D640 Offset: 0x200D741 VA: 0x200D640
	public void OnNice() { }

	// RVA: 0x200D7A0 Offset: 0x200D8A1 VA: 0x200D7A0
	public void OnBad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF140 Offset: 0x1AF241 VA: 0x1AF140
	// RVA: 0x200D5C0 Offset: 0x200D6C1 VA: 0x200D5C0
	private IEnumerator DelayDisable(Image image) { }

	// RVA: 0x200D930 Offset: 0x200DA31 VA: 0x200D930
	public void UpdateTimeText(float time) { }

	// RVA: 0x200D950 Offset: 0x200DA51 VA: 0x200D950
	public void BlackFadeScreen(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF1B0 Offset: 0x1AF2B1 VA: 0x1AF1B0
	// RVA: 0x200DA10 Offset: 0x200DB11 VA: 0x200DA10
	private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback) { }

	// RVA: 0x200DB00 Offset: 0x200DC01 VA: 0x200DB00
	public void .ctor() { }
}

public class UIDualWork : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	[SerializeField] // RVA: 0x181760 Offset: 0x181861 VA: 0x181760
	private Image SynchroGauge; // 0x18
	[SerializeField] // RVA: 0x181770 Offset: 0x181871 VA: 0x181770
	private RectTransform SynchroNorma; // 0x20
	[SerializeField] // RVA: 0x181780 Offset: 0x181881 VA: 0x181780
	private RectTransform SynchroKirakira; // 0x28
	[SerializeField] // RVA: 0x181790 Offset: 0x181891 VA: 0x181790
	private Image SuccessGauge; // 0x30
	[SerializeField] // RVA: 0x1817A0 Offset: 0x1818A1 VA: 0x1817A0
	private Image CriticalGauge; // 0x38
	[SerializeField] // RVA: 0x1817B0 Offset: 0x1818B1 VA: 0x1817B0
	private RectTransform TimingBar; // 0x40
	[SerializeField] // RVA: 0x1817C0 Offset: 0x1818C1 VA: 0x1817C0
	private RectTransform TimingGauge; // 0x48
	[SerializeField] // RVA: 0x1817D0 Offset: 0x1818D1 VA: 0x1817D0
	private GameObject PerfectImpact; // 0x50
	[SerializeField] // RVA: 0x1817E0 Offset: 0x1818E1 VA: 0x1817E0
	private GameObject NiceImpact; // 0x58
	[SerializeField] // RVA: 0x1817F0 Offset: 0x1818F1 VA: 0x1817F0
	private GameObject BadImpact; // 0x60
	[SerializeField] // RVA: 0x181800 Offset: 0x181901 VA: 0x181800
	private Image PerfectImage; // 0x68
	[SerializeField] // RVA: 0x181810 Offset: 0x181911 VA: 0x181810
	private Image NiceImage; // 0x70
	[SerializeField] // RVA: 0x181820 Offset: 0x181921 VA: 0x181820
	private Image BadImage; // 0x78
	[SerializeField] // RVA: 0x181830 Offset: 0x181931 VA: 0x181830
	private FestivalNumScore TimerUI; // 0x80
	[SerializeField] // RVA: 0x181840 Offset: 0x181941 VA: 0x181840
	private Image FadeImage; // 0x88
	private Coroutine PrevCoroutine; // 0x90

	// Methods

	// RVA: 0x200CE50 Offset: 0x200CF51 VA: 0x200CE50
	public void SetSynchroGauge(float gauge) { }

	// RVA: 0x200CFD0 Offset: 0x200D0D1 VA: 0x200CFD0
	public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition) { }

	// RVA: 0x200D1D0 Offset: 0x200D2D1 VA: 0x200D1D0
	public void Init() { }

	// RVA: 0x200D270 Offset: 0x200D371 VA: 0x200D270
	public void SetPosTimingbar(float position) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF0D0 Offset: 0x1AF1D1 VA: 0x1AF0D0
	// RVA: 0x200D390 Offset: 0x200D491 VA: 0x200D390
	private IEnumerator FadeBarImpactEffect(GameObject gameObject) { }

	// RVA: 0x200D460 Offset: 0x200D561 VA: 0x200D460
	public void OnPerfect() { }

	// RVA: 0x200D640 Offset: 0x200D741 VA: 0x200D640
	public void OnNice() { }

	// RVA: 0x200D7A0 Offset: 0x200D8A1 VA: 0x200D7A0
	public void OnBad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF140 Offset: 0x1AF241 VA: 0x1AF140
	// RVA: 0x200D5C0 Offset: 0x200D6C1 VA: 0x200D5C0
	private IEnumerator DelayDisable(Image image) { }

	// RVA: 0x200D930 Offset: 0x200DA31 VA: 0x200D930
	public void UpdateTimeText(float time) { }

	// RVA: 0x200D950 Offset: 0x200DA51 VA: 0x200D950
	public void BlackFadeScreen(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF1B0 Offset: 0x1AF2B1 VA: 0x1AF1B0
	// RVA: 0x200DA10 Offset: 0x200DB11 VA: 0x200DA10
	private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback) { }

	// RVA: 0x200DB00 Offset: 0x200DC01 VA: 0x200DB00
	public void .ctor() { }
}

public class UIDualWork : MonoBehaviour // TypeDefIndex: 10396
{
	// Fields
	[SerializeField] // RVA: 0x181760 Offset: 0x181861 VA: 0x181760
	private Image SynchroGauge; // 0x18
	[SerializeField] // RVA: 0x181770 Offset: 0x181871 VA: 0x181770
	private RectTransform SynchroNorma; // 0x20
	[SerializeField] // RVA: 0x181780 Offset: 0x181881 VA: 0x181780
	private RectTransform SynchroKirakira; // 0x28
	[SerializeField] // RVA: 0x181790 Offset: 0x181891 VA: 0x181790
	private Image SuccessGauge; // 0x30
	[SerializeField] // RVA: 0x1817A0 Offset: 0x1818A1 VA: 0x1817A0
	private Image CriticalGauge; // 0x38
	[SerializeField] // RVA: 0x1817B0 Offset: 0x1818B1 VA: 0x1817B0
	private RectTransform TimingBar; // 0x40
	[SerializeField] // RVA: 0x1817C0 Offset: 0x1818C1 VA: 0x1817C0
	private RectTransform TimingGauge; // 0x48
	[SerializeField] // RVA: 0x1817D0 Offset: 0x1818D1 VA: 0x1817D0
	private GameObject PerfectImpact; // 0x50
	[SerializeField] // RVA: 0x1817E0 Offset: 0x1818E1 VA: 0x1817E0
	private GameObject NiceImpact; // 0x58
	[SerializeField] // RVA: 0x1817F0 Offset: 0x1818F1 VA: 0x1817F0
	private GameObject BadImpact; // 0x60
	[SerializeField] // RVA: 0x181800 Offset: 0x181901 VA: 0x181800
	private Image PerfectImage; // 0x68
	[SerializeField] // RVA: 0x181810 Offset: 0x181911 VA: 0x181810
	private Image NiceImage; // 0x70
	[SerializeField] // RVA: 0x181820 Offset: 0x181921 VA: 0x181820
	private Image BadImage; // 0x78
	[SerializeField] // RVA: 0x181830 Offset: 0x181931 VA: 0x181830
	private FestivalNumScore TimerUI; // 0x80
	[SerializeField] // RVA: 0x181840 Offset: 0x181941 VA: 0x181840
	private Image FadeImage; // 0x88
	private Coroutine PrevCoroutine; // 0x90

	// Methods

	// RVA: 0x200CE50 Offset: 0x200CF51 VA: 0x200CE50
	public void SetSynchroGauge(float gauge) { }

	// RVA: 0x200CFD0 Offset: 0x200D0D1 VA: 0x200CFD0
	public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition) { }

	// RVA: 0x200D1D0 Offset: 0x200D2D1 VA: 0x200D1D0
	public void Init() { }

	// RVA: 0x200D270 Offset: 0x200D371 VA: 0x200D270
	public void SetPosTimingbar(float position) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF0D0 Offset: 0x1AF1D1 VA: 0x1AF0D0
	// RVA: 0x200D390 Offset: 0x200D491 VA: 0x200D390
	private IEnumerator FadeBarImpactEffect(GameObject gameObject) { }

	// RVA: 0x200D460 Offset: 0x200D561 VA: 0x200D460
	public void OnPerfect() { }

	// RVA: 0x200D640 Offset: 0x200D741 VA: 0x200D640
	public void OnNice() { }

	// RVA: 0x200D7A0 Offset: 0x200D8A1 VA: 0x200D7A0
	public void OnBad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF140 Offset: 0x1AF241 VA: 0x1AF140
	// RVA: 0x200D5C0 Offset: 0x200D6C1 VA: 0x200D5C0
	private IEnumerator DelayDisable(Image image) { }

	// RVA: 0x200D930 Offset: 0x200DA31 VA: 0x200D930
	public void UpdateTimeText(float time) { }

	// RVA: 0x200D950 Offset: 0x200DA51 VA: 0x200D950
	public void BlackFadeScreen(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF1B0 Offset: 0x1AF2B1 VA: 0x1AF1B0
	// RVA: 0x200DA10 Offset: 0x200DB11 VA: 0x200DA10
	private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback) { }

	// RVA: 0x200DB00 Offset: 0x200DC01 VA: 0x200DB00
	public void .ctor() { }
}

