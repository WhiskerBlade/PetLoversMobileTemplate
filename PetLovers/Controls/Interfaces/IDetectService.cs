using System;
using PetLovers.Models;

namespace PetLovers.Controls.Interfaces
{
    public interface IDetectService
    {
        DetectResult Detect(byte[] file);
    }
}
