using System.Collections.Generic;

namespace REC.Intrinsic
{
    public interface IIntrinsicDict : IEnumerable<IIntrinsic>
    {
        Dictionary<string, IIntrinsic> Dict { get; }

        IIntrinsic this[string key] { get; }
    }
}