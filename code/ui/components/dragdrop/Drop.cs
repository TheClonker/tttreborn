using System.Collections.Generic;

using Sandbox.UI;

// TODO use M4x4 transform

namespace TTTReborn.UI
{
    public partial class Drop : DragDrop
    {
        public static List<Drop> List { get; private set; } = new();

        public Drop(Sandbox.UI.Panel parent = null) : base(parent)
        {
            Parent = parent ?? Parent;

            List.Add(this);

            StyleSheet.Load("/ui/components/dragdrop/Drop.scss");
        }

        public override void OnDeleted()
        {
            List.Remove(this);
        }
    }
}
