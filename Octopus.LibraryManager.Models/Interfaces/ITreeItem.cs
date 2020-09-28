using System;

namespace Octopus.LibraryManager.Models.Interfaces
{
    public interface ITreeItem
    {
        /// <summary>
        /// Gets or sets the global unique identifier of the catalog node object.
        /// </summary>
        public Guid Guid { get; }

        /// <summary>
        /// Gets or sets the parent node of the catalog node object.
        /// </summary>
        public ITreeFolder Parent { get; set; }

        /// <summary>
        /// Gets or sets the title of the catalog node object.
        /// </summary>
        public string Title { get; set; }
    }
}
