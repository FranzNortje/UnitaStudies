using System;

namespace NEFGLibrary
{
  public class ProductArtifact
  {
    public ProductArtifactType ArtifactType { get; set; }
    public string ArtifactPath { get; set; }
    public string FileName { get; set; }
    public bool Enabled { get; set; }
    public int Version { get; set; }
    public DateTime CreationDate { get; set; }
  }
}