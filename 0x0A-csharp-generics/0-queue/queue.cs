using System;

/// <summary>
/// Generic class.
/// </summary>
/// <typeparam name="T">The type of object.</typeparam>
class Queue<T>
{

	/// <summary>
	/// Checks type of object.
	/// </summary>
	/// <returns>Object type.</returns>
	public Type CheckType()
	{
		return typeof(T);
	}
}