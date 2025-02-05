using System;
using System.Collections.Generic;

public class GetDataByPage<T>
{
	public CSGetDataByPage csMessage;

	private List<T> _data;

	public T myData;

	public Dictionary<int, List<T>> dataByPage;

	public int totalPage;

	public int curPage;

	public Action onGetData;

	public List<T> Data => null;

	public void GetData(int page)
	{
	}

	public virtual void RequestGetData(int page)
	{
	}

	public void GetDataFromServer(List<T> data, T myData, int curPage, int totalPage)
	{
	}

	public void ClearCache()
	{
	}
}
