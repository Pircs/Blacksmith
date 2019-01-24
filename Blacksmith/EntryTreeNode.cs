﻿using Blacksmith.Enums;
using System.Windows.Forms;

namespace Blacksmith
{
    public class EntryTreeNode : TreeNode
    {
        public Game Game;
        public string Path;
        public ResourceType ResourceType = ResourceType._NONE;
        public long Size = -1;
    }
}