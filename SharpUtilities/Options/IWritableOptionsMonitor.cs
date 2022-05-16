using Microsoft.Extensions.Options;

namespace SharpUtilities.Options;

public interface IWritableOptionsMonitor<out TOptions> : IOptionsMonitor<TOptions> where TOptions : class
{
    bool Update(Action<TOptions> applyChanges);
    Task<bool> UpdateAsync(Action<TOptions> applyChanges);
}