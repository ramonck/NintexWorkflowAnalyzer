
using System.ComponentModel;

namespace ULSPack.BPARules
{
    public interface IULSBPARule
    {
        bool MatchesRule { get; }

        void Initialize();

        void Execute();
    }
}
