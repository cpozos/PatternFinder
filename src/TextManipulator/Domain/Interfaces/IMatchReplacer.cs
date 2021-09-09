﻿using TextManipulator.Domain.Entities;

namespace TextManipulator.Domain.Interfaces
{
   public interface IMatchReplacer
   {
      string Replace(FileMatch match);
   }
}
