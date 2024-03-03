using skakus.data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.domain.Configuration
{
    public class SkakusDomainProfile: Profile
    {
        public SkakusDomainProfile()
        {
            InitMaps();
        }

        private void InitMaps()
        {
            CreateMap<Game, Entities.Game>();
        }
    }
}
