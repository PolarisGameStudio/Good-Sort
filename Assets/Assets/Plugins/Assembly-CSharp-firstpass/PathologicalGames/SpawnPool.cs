using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PathologicalGames
{
	[AddComponentMenu("Path-o-logical/PoolManager/SpawnPool")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		public delegate void DestroyDelegate(GameObject instance);
		public string poolName;

		public bool matchPoolScale;

		public bool matchPoolLayer;

		public bool dontReparent;

		public bool _dontDestroyOnLoad;

		public bool logMessages;

		public List<PrefabPool> _perPrefabPoolOptions;

		public Dictionary<object, bool> prefabsFoldOutStates;

		public float maxParticleDespawnTime;

		public PrefabsDict prefabs;

		public Dictionary<object, bool> _editorListItemStates;

		private List<PrefabPool> _prefabPools;

		internal List<Transform> _spawned;

		public InstantiateDelegate instantiateDelegates;

		public DestroyDelegate destroyDelegates;

		public bool dontDestroyOnLoad
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform group { get; private set; }

		public Dictionary<string, PrefabPool> prefabPools => null;

		public Transform this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		private void Awake()
		{
		}

		internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		internal void DestroyInstance(GameObject instance)
		{
		}

		private void OnDestroy()
		{
		}

		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		public void Add(Transform item)
		{
		}

		public void Remove(Transform item)
		{
		}

		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		public Transform Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		public Transform Spawn(string prefabName)
		{
			return null;
		}

		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		public void Despawn(Transform instance)
		{
		}

		public void Despawn(Transform instance, Transform parent)
		{
		}

		public void Despawn(Transform instance, float seconds)
		{
		}

		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		public void DespawnAll()
		{
		}

		public bool IsSpawned(Transform instance)
		{
			return false;
		}

		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		private IEnumerator ListForAudioStop(AudioSource src)
		{
			return null;
		}

		private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Contains(Transform item)
		{
			return false;
		}

		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(Transform item)
		{
			return 0;
		}

		public void Insert(int index, Transform item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		bool ICollection<Transform>.Remove(Transform item)
		{
			return false;
		}

		public void Spawn(object explosiveShot, object pos, Quaternion identity)
		{
		}
	}
}
