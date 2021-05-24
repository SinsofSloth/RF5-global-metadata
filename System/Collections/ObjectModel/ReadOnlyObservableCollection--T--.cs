[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 2069
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD000 Offset: 0xBD101 VA: 0xBD000
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD010 Offset: 0xBD111 VA: 0xBD010
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37930 Offset: 0x2C37A31 VA: 0x2C37930
	|-ReadOnlyObservableCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BA0 Offset: 0x2C37CA1 VA: 0x2C37BA0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BC0 Offset: 0x2C37CC1 VA: 0x2C37BC0
	|-ReadOnlyObservableCollection<object>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC10 Offset: 0xBDD11 VA: 0xBDC10
	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37BE0 Offset: 0x2C37CE1 VA: 0x2C37BE0
	|-ReadOnlyObservableCollection<object>.add_CollectionChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC20 Offset: 0xBDD21 VA: 0xBDC20
	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37CA0 Offset: 0x2C37DA1 VA: 0x2C37CA0
	|-ReadOnlyObservableCollection<object>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D60 Offset: 0x2C37E61 VA: 0x2C37D60
	|-ReadOnlyObservableCollection<object>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37D80 Offset: 0x2C37E81 VA: 0x2C37D80
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DA0 Offset: 0x2C37EA1 VA: 0x2C37DA0
	|-ReadOnlyObservableCollection<object>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC30 Offset: 0xBDD31 VA: 0xBDC30
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37DC0 Offset: 0x2C37EC1 VA: 0x2C37DC0
	|-ReadOnlyObservableCollection<object>.add_PropertyChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC40 Offset: 0xBDD41 VA: 0xBDC40
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37E80 Offset: 0x2C37F81 VA: 0x2C37E80
	|-ReadOnlyObservableCollection<object>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F40 Offset: 0x2C38041 VA: 0x2C37F40
	|-ReadOnlyObservableCollection<object>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F60 Offset: 0x2C38061 VA: 0x2C37F60
	|-ReadOnlyObservableCollection<object>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C37F90 Offset: 0x2C38091 VA: 0x2C37F90
	|-ReadOnlyObservableCollection<object>.HandlePropertyChanged
	*/
}

