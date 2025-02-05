using System;

public interface IEvent
{
	bool IsUnlock();

	bool CanActive();

	bool IsWaiting();

	bool IsPlaying();

	bool IsEnd();

	void EndSession();

	void AddActionReset(Action action);

	int GetNumPlay();

	void ResetWhenEnd();
}
