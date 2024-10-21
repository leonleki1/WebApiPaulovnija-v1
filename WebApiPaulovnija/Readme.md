<a name='assembly'></a>
# WebApiPaulovnija

## Contents

- [AzurirajRadnikaDTO](#T-WebApiPaulovnija-DTO-AzurirajRadnikaDTO 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO')
  - [Godine](#P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Godine 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO.Godine')
  - [Ime](#P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Ime 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO.Ime')
  - [Plata](#P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Plata 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO.Plata')
  - [Pozicija](#P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Pozicija 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO.Pozicija')
  - [Prezime](#P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Prezime 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO.Prezime')
- [AzurirajRasadnikDTO](#T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO')
  - [Datum_otvaranja](#P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Datum_otvaranja 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO.Datum_otvaranja')
  - [ID_Rasadnika](#P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-ID_Rasadnika 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO.ID_Rasadnika')
  - [Lokacija](#P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Lokacija 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO.Lokacija')
  - [Naziv](#P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Naziv 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO.Naziv')
  - [Povrsina](#P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Povrsina 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO.Povrsina')
- [AzurirajSadnicuDTO](#T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO')
  - [DatumSadnje](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-DatumSadnje 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.DatumSadnje')
  - [ID_Rasadnika](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-ID_Rasadnika 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.ID_Rasadnika')
  - [ID_Sadnice](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-ID_Sadnice 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.ID_Sadnice')
  - [Starost](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Starost 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.Starost')
  - [Visina](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Visina 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.Visina')
  - [Vrsta](#P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Vrsta 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO.Vrsta')
- [AzurirajStrojDTO](#T-WebApiPaulovnija-DTO-AzurirajStrojDTO 'WebApiPaulovnija.DTO.AzurirajStrojDTO')
  - [Godiste](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Godiste 'WebApiPaulovnija.DTO.AzurirajStrojDTO.Godiste')
  - [ID_Radnika](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-ID_Radnika 'WebApiPaulovnija.DTO.AzurirajStrojDTO.ID_Radnika')
  - [ID_Stroja](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-ID_Stroja 'WebApiPaulovnija.DTO.AzurirajStrojDTO.ID_Stroja')
  - [Kapacitet_rezervoara](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Kapacitet_rezervoara 'WebApiPaulovnija.DTO.AzurirajStrojDTO.Kapacitet_rezervoara')
  - [Marka](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Marka 'WebApiPaulovnija.DTO.AzurirajStrojDTO.Marka')
  - [Model](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Model 'WebApiPaulovnija.DTO.AzurirajStrojDTO.Model')
  - [Tip](#P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Tip 'WebApiPaulovnija.DTO.AzurirajStrojDTO.Tip')
- [AzurirajZadatakDTO](#T--AzurirajZadatakDTO '.AzurirajZadatakDTO')
  - [Datum_pocetka](#P-AzurirajZadatakDTO-Datum_pocetka 'AzurirajZadatakDTO.Datum_pocetka')
  - [Datum_zavrsetka](#P-AzurirajZadatakDTO-Datum_zavrsetka 'AzurirajZadatakDTO.Datum_zavrsetka')
  - [ID_Radnika](#P-AzurirajZadatakDTO-ID_Radnika 'AzurirajZadatakDTO.ID_Radnika')
  - [ID_Zadatka](#P-AzurirajZadatakDTO-ID_Zadatka 'AzurirajZadatakDTO.ID_Zadatka')
  - [Opis](#P-AzurirajZadatakDTO-Opis 'AzurirajZadatakDTO.Opis')
  - [Status_Zadatka](#P-AzurirajZadatakDTO-Status_Zadatka 'AzurirajZadatakDTO.Status_Zadatka')
- [IRadnikService](#T-WebApiPaulovnija-Services-IRadnikService 'WebApiPaulovnija.Services.IRadnikService')
  - [CreateRadnikAsync(radnik)](#M-WebApiPaulovnija-Services-IRadnikService-CreateRadnikAsync-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Services.IRadnikService.CreateRadnikAsync(WebApiPaulovnija.Models.Radnik)')
  - [DeleteRadnikAsync(id)](#M-WebApiPaulovnija-Services-IRadnikService-DeleteRadnikAsync-System-Int32- 'WebApiPaulovnija.Services.IRadnikService.DeleteRadnikAsync(System.Int32)')
  - [GetAllRadniciAsync()](#M-WebApiPaulovnija-Services-IRadnikService-GetAllRadniciAsync 'WebApiPaulovnija.Services.IRadnikService.GetAllRadniciAsync')
  - [GetRadnikByIdAsync(id)](#M-WebApiPaulovnija-Services-IRadnikService-GetRadnikByIdAsync-System-Int32- 'WebApiPaulovnija.Services.IRadnikService.GetRadnikByIdAsync(System.Int32)')
  - [UpdateRadnikAsync(radnik)](#M-WebApiPaulovnija-Services-IRadnikService-UpdateRadnikAsync-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Services.IRadnikService.UpdateRadnikAsync(WebApiPaulovnija.Models.Radnik)')
- [IRasadnikService](#T-WebApiPaulovnija-Services-IRasadnikService 'WebApiPaulovnija.Services.IRasadnikService')
  - [CreateRasadnikAsync(rasadnikDTO)](#M-WebApiPaulovnija-Services-IRasadnikService-CreateRasadnikAsync-WebApiPaulovnija-DTO-KreirajRasadnikDTO- 'WebApiPaulovnija.Services.IRasadnikService.CreateRasadnikAsync(WebApiPaulovnija.DTO.KreirajRasadnikDTO)')
  - [DeleteRasadnikAsync(id)](#M-WebApiPaulovnija-Services-IRasadnikService-DeleteRasadnikAsync-System-Int32- 'WebApiPaulovnija.Services.IRasadnikService.DeleteRasadnikAsync(System.Int32)')
  - [GetAllRasadniciAsync()](#M-WebApiPaulovnija-Services-IRasadnikService-GetAllRasadniciAsync 'WebApiPaulovnija.Services.IRasadnikService.GetAllRasadniciAsync')
  - [GetRasadnikByIdAsync(id)](#M-WebApiPaulovnija-Services-IRasadnikService-GetRasadnikByIdAsync-System-Int32- 'WebApiPaulovnija.Services.IRasadnikService.GetRasadnikByIdAsync(System.Int32)')
  - [UpdateRasadnikAsync(rasadnik)](#M-WebApiPaulovnija-Services-IRasadnikService-UpdateRasadnikAsync-WebApiPaulovnija-DTO-AzurirajRasadnikDTO- 'WebApiPaulovnija.Services.IRasadnikService.UpdateRasadnikAsync(WebApiPaulovnija.DTO.AzurirajRasadnikDTO)')
- [ISadnicaService](#T-WebApiPaulovnija-Services-ISadnicaService 'WebApiPaulovnija.Services.ISadnicaService')
  - [AddAsync(sadnicaDTO)](#M-WebApiPaulovnija-Services-ISadnicaService-AddAsync-WebApiPaulovnija-DTO-KreirajSadnicuDTO- 'WebApiPaulovnija.Services.ISadnicaService.AddAsync(WebApiPaulovnija.DTO.KreirajSadnicuDTO)')
  - [DeleteAsync(id)](#M-WebApiPaulovnija-Services-ISadnicaService-DeleteAsync-System-Int32- 'WebApiPaulovnija.Services.ISadnicaService.DeleteAsync(System.Int32)')
  - [GetAllAsync()](#M-WebApiPaulovnija-Services-ISadnicaService-GetAllAsync 'WebApiPaulovnija.Services.ISadnicaService.GetAllAsync')
  - [GetByIdAsync(id)](#M-WebApiPaulovnija-Services-ISadnicaService-GetByIdAsync-System-Int32- 'WebApiPaulovnija.Services.ISadnicaService.GetByIdAsync(System.Int32)')
  - [UpdateAsync(sadnicaDTO)](#M-WebApiPaulovnija-Services-ISadnicaService-UpdateAsync-WebApiPaulovnija-DTO-AzurirajSadnicuDTO- 'WebApiPaulovnija.Services.ISadnicaService.UpdateAsync(WebApiPaulovnija.DTO.AzurirajSadnicuDTO)')
- [IStrojService](#T-WebApiPaulovnija-Services-IStrojService 'WebApiPaulovnija.Services.IStrojService')
  - [AddAsync(stroj)](#M-WebApiPaulovnija-Services-IStrojService-AddAsync-WebApiPaulovnija-Models-Stroj- 'WebApiPaulovnija.Services.IStrojService.AddAsync(WebApiPaulovnija.Models.Stroj)')
  - [DeleteAsync(id)](#M-WebApiPaulovnija-Services-IStrojService-DeleteAsync-System-Int32- 'WebApiPaulovnija.Services.IStrojService.DeleteAsync(System.Int32)')
  - [GetAllAsync()](#M-WebApiPaulovnija-Services-IStrojService-GetAllAsync 'WebApiPaulovnija.Services.IStrojService.GetAllAsync')
  - [GetByIdAsync(id)](#M-WebApiPaulovnija-Services-IStrojService-GetByIdAsync-System-Int32- 'WebApiPaulovnija.Services.IStrojService.GetByIdAsync(System.Int32)')
  - [UpdateAsync(stroj)](#M-WebApiPaulovnija-Services-IStrojService-UpdateAsync-WebApiPaulovnija-Models-Stroj- 'WebApiPaulovnija.Services.IStrojService.UpdateAsync(WebApiPaulovnija.Models.Stroj)')
- [IZadatakService](#T--IZadatakService '.IZadatakService')
  - [CreateZadatakAsync(dto)](#M-IZadatakService-CreateZadatakAsync-KreirajZadatakDTO- 'IZadatakService.CreateZadatakAsync(KreirajZadatakDTO)')
  - [DeleteZadatakAsync(id)](#M-IZadatakService-DeleteZadatakAsync-System-Int32- 'IZadatakService.DeleteZadatakAsync(System.Int32)')
  - [GetAllZadaciAsync()](#M-IZadatakService-GetAllZadaciAsync 'IZadatakService.GetAllZadaciAsync')
  - [GetZadatakByIdAsync(id)](#M-IZadatakService-GetZadatakByIdAsync-System-Int32- 'IZadatakService.GetZadatakByIdAsync(System.Int32)')
  - [UpdateZadatakAsync(dto)](#M-IZadatakService-UpdateZadatakAsync-AzurirajZadatakDTO- 'IZadatakService.UpdateZadatakAsync(AzurirajZadatakDTO)')
- [KreirajRadnikaDTO](#T-WebApiPaulovnija-DTO-KreirajRadnikaDTO 'WebApiPaulovnija.DTO.KreirajRadnikaDTO')
  - [Godine](#P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Godine 'WebApiPaulovnija.DTO.KreirajRadnikaDTO.Godine')
  - [Ime](#P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Ime 'WebApiPaulovnija.DTO.KreirajRadnikaDTO.Ime')
  - [Plata](#P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Plata 'WebApiPaulovnija.DTO.KreirajRadnikaDTO.Plata')
  - [Pozicija](#P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Pozicija 'WebApiPaulovnija.DTO.KreirajRadnikaDTO.Pozicija')
  - [Prezime](#P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Prezime 'WebApiPaulovnija.DTO.KreirajRadnikaDTO.Prezime')
- [KreirajRasadnikDTO](#T-WebApiPaulovnija-DTO-KreirajRasadnikDTO 'WebApiPaulovnija.DTO.KreirajRasadnikDTO')
  - [Datum_otvaranja](#P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Datum_otvaranja 'WebApiPaulovnija.DTO.KreirajRasadnikDTO.Datum_otvaranja')
  - [Lokacija](#P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Lokacija 'WebApiPaulovnija.DTO.KreirajRasadnikDTO.Lokacija')
  - [Naziv](#P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Naziv 'WebApiPaulovnija.DTO.KreirajRasadnikDTO.Naziv')
  - [Povrsina](#P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Povrsina 'WebApiPaulovnija.DTO.KreirajRasadnikDTO.Povrsina')
- [KreirajSadnicuDTO](#T-WebApiPaulovnija-DTO-KreirajSadnicuDTO 'WebApiPaulovnija.DTO.KreirajSadnicuDTO')
  - [Datum_sadnje](#P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Datum_sadnje 'WebApiPaulovnija.DTO.KreirajSadnicuDTO.Datum_sadnje')
  - [ID_Rasadnika](#P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-ID_Rasadnika 'WebApiPaulovnija.DTO.KreirajSadnicuDTO.ID_Rasadnika')
  - [Starost](#P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Starost 'WebApiPaulovnija.DTO.KreirajSadnicuDTO.Starost')
  - [Visina](#P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Visina 'WebApiPaulovnija.DTO.KreirajSadnicuDTO.Visina')
  - [Vrsta](#P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Vrsta 'WebApiPaulovnija.DTO.KreirajSadnicuDTO.Vrsta')
- [KreirajStrojDTO](#T-WebApiPaulovnija-DTO-KreirajStrojDTO 'WebApiPaulovnija.DTO.KreirajStrojDTO')
  - [Godiste](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-Godiste 'WebApiPaulovnija.DTO.KreirajStrojDTO.Godiste')
  - [ID_Radnika](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-ID_Radnika 'WebApiPaulovnija.DTO.KreirajStrojDTO.ID_Radnika')
  - [Kapacitet_rezervoara](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-Kapacitet_rezervoara 'WebApiPaulovnija.DTO.KreirajStrojDTO.Kapacitet_rezervoara')
  - [Marka](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-Marka 'WebApiPaulovnija.DTO.KreirajStrojDTO.Marka')
  - [Model](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-Model 'WebApiPaulovnija.DTO.KreirajStrojDTO.Model')
  - [Tip](#P-WebApiPaulovnija-DTO-KreirajStrojDTO-Tip 'WebApiPaulovnija.DTO.KreirajStrojDTO.Tip')
- [KreirajZadatakDTO](#T--KreirajZadatakDTO '.KreirajZadatakDTO')
  - [Datum_pocetka](#P-KreirajZadatakDTO-Datum_pocetka 'KreirajZadatakDTO.Datum_pocetka')
  - [Datum_zavrsetka](#P-KreirajZadatakDTO-Datum_zavrsetka 'KreirajZadatakDTO.Datum_zavrsetka')
  - [ID_Radnika](#P-KreirajZadatakDTO-ID_Radnika 'KreirajZadatakDTO.ID_Radnika')
  - [Opis](#P-KreirajZadatakDTO-Opis 'KreirajZadatakDTO.Opis')
  - [Status_Zadatka](#P-KreirajZadatakDTO-Status_Zadatka 'KreirajZadatakDTO.Status_Zadatka')
- [MappingProfile](#T-WebApiPaulovnija-Mapping-MappingProfile 'WebApiPaulovnija.Mapping.MappingProfile')
  - [#ctor()](#M-WebApiPaulovnija-Mapping-MappingProfile-#ctor 'WebApiPaulovnija.Mapping.MappingProfile.#ctor')
- [PaulovnijaContext](#T--PaulovnijaContext '.PaulovnijaContext')
  - [#ctor(options)](#M-PaulovnijaContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{PaulovnijaContext}- 'PaulovnijaContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{PaulovnijaContext})')
  - [Radnici](#P-PaulovnijaContext-Radnici 'PaulovnijaContext.Radnici')
  - [Rasadnik](#P-PaulovnijaContext-Rasadnik 'PaulovnijaContext.Rasadnik')
  - [Sadnice](#P-PaulovnijaContext-Sadnice 'PaulovnijaContext.Sadnice')
  - [Strojevi](#P-PaulovnijaContext-Strojevi 'PaulovnijaContext.Strojevi')
  - [Zadaci](#P-PaulovnijaContext-Zadaci 'PaulovnijaContext.Zadaci')
  - [OnModelCreating(modelBuilder)](#M-PaulovnijaContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'PaulovnijaContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')
- [RadniciList](#T-WebApiPaulovnija-Controllers-Models-RadniciList 'WebApiPaulovnija.Controllers.Models.RadniciList')
  - [ListaRadnika](#P-WebApiPaulovnija-Controllers-Models-RadniciList-ListaRadnika 'WebApiPaulovnija.Controllers.Models.RadniciList.ListaRadnika')
- [Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik')
  - [Godine](#P-WebApiPaulovnija-Models-Radnik-Godine 'WebApiPaulovnija.Models.Radnik.Godine')
  - [ID_Radnika](#P-WebApiPaulovnija-Models-Radnik-ID_Radnika 'WebApiPaulovnija.Models.Radnik.ID_Radnika')
  - [Ime](#P-WebApiPaulovnija-Models-Radnik-Ime 'WebApiPaulovnija.Models.Radnik.Ime')
  - [Plata](#P-WebApiPaulovnija-Models-Radnik-Plata 'WebApiPaulovnija.Models.Radnik.Plata')
  - [Pozicija](#P-WebApiPaulovnija-Models-Radnik-Pozicija 'WebApiPaulovnija.Models.Radnik.Pozicija')
  - [Prezime](#P-WebApiPaulovnija-Models-Radnik-Prezime 'WebApiPaulovnija.Models.Radnik.Prezime')
  - [Strojevi](#P-WebApiPaulovnija-Models-Radnik-Strojevi 'WebApiPaulovnija.Models.Radnik.Strojevi')
  - [Zadaci](#P-WebApiPaulovnija-Models-Radnik-Zadaci 'WebApiPaulovnija.Models.Radnik.Zadaci')
- [RadnikController](#T-WebApiPaulovnija-Controllers-RadnikController 'WebApiPaulovnija.Controllers.RadnikController')
  - [Delete(id)](#M-WebApiPaulovnija-Controllers-RadnikController-Delete-System-Int32- 'WebApiPaulovnija.Controllers.RadnikController.Delete(System.Int32)')
  - [Get()](#M-WebApiPaulovnija-Controllers-RadnikController-Get 'WebApiPaulovnija.Controllers.RadnikController.Get')
  - [GetById(id)](#M-WebApiPaulovnija-Controllers-RadnikController-GetById-System-Int32- 'WebApiPaulovnija.Controllers.RadnikController.GetById(System.Int32)')
  - [Post(dto)](#M-WebApiPaulovnija-Controllers-RadnikController-Post-WebApiPaulovnija-DTO-KreirajRadnikaDTO- 'WebApiPaulovnija.Controllers.RadnikController.Post(WebApiPaulovnija.DTO.KreirajRadnikaDTO)')
  - [Put(id,dto)](#M-WebApiPaulovnija-Controllers-RadnikController-Put-System-Int32,WebApiPaulovnija-DTO-AzurirajRadnikaDTO- 'WebApiPaulovnija.Controllers.RadnikController.Put(System.Int32,WebApiPaulovnija.DTO.AzurirajRadnikaDTO)')
- [RadnikDTO](#T-RadnikDTO 'RadnikDTO')
  - [Godine](#P-RadnikDTO-Godine 'RadnikDTO.Godine')
  - [ID_Radnika](#P-RadnikDTO-ID_Radnika 'RadnikDTO.ID_Radnika')
  - [Ime](#P-RadnikDTO-Ime 'RadnikDTO.Ime')
  - [Plata](#P-RadnikDTO-Plata 'RadnikDTO.Plata')
  - [Pozicija](#P-RadnikDTO-Pozicija 'RadnikDTO.Pozicija')
  - [Prezime](#P-RadnikDTO-Prezime 'RadnikDTO.Prezime')
- [RadnikService](#T-WebApiPaulovnija-Service-RadnikService 'WebApiPaulovnija.Service.RadnikService')
  - [#ctor(context)](#M-WebApiPaulovnija-Service-RadnikService-#ctor-PaulovnijaContext- 'WebApiPaulovnija.Service.RadnikService.#ctor(PaulovnijaContext)')
  - [CreateRadnik(radnik)](#M-WebApiPaulovnija-Service-RadnikService-CreateRadnik-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Service.RadnikService.CreateRadnik(WebApiPaulovnija.Models.Radnik)')
  - [CreateRadnikAsync(radnik)](#M-WebApiPaulovnija-Service-RadnikService-CreateRadnikAsync-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Service.RadnikService.CreateRadnikAsync(WebApiPaulovnija.Models.Radnik)')
  - [DeleteRadnik(radnik)](#M-WebApiPaulovnija-Service-RadnikService-DeleteRadnik-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Service.RadnikService.DeleteRadnik(WebApiPaulovnija.Models.Radnik)')
  - [DeleteRadnikAsync(id)](#M-WebApiPaulovnija-Service-RadnikService-DeleteRadnikAsync-System-Int32- 'WebApiPaulovnija.Service.RadnikService.DeleteRadnikAsync(System.Int32)')
  - [GetAllRadnici()](#M-WebApiPaulovnija-Service-RadnikService-GetAllRadnici 'WebApiPaulovnija.Service.RadnikService.GetAllRadnici')
  - [GetAllRadniciAsync()](#M-WebApiPaulovnija-Service-RadnikService-GetAllRadniciAsync 'WebApiPaulovnija.Service.RadnikService.GetAllRadniciAsync')
  - [GetRadnikById(id)](#M-WebApiPaulovnija-Service-RadnikService-GetRadnikById-System-Int32- 'WebApiPaulovnija.Service.RadnikService.GetRadnikById(System.Int32)')
  - [GetRadnikByIdAsync(id)](#M-WebApiPaulovnija-Service-RadnikService-GetRadnikByIdAsync-System-Int32- 'WebApiPaulovnija.Service.RadnikService.GetRadnikByIdAsync(System.Int32)')
  - [UpdateRadnik(radnik)](#M-WebApiPaulovnija-Service-RadnikService-UpdateRadnik-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Service.RadnikService.UpdateRadnik(WebApiPaulovnija.Models.Radnik)')
  - [UpdateRadnikAsync(radnik)](#M-WebApiPaulovnija-Service-RadnikService-UpdateRadnikAsync-WebApiPaulovnija-Models-Radnik- 'WebApiPaulovnija.Service.RadnikService.UpdateRadnikAsync(WebApiPaulovnija.Models.Radnik)')
- [RasadniciController](#T-WebApiPaulovnija-Controllers-RasadniciController 'WebApiPaulovnija.Controllers.RasadniciController')
  - [CreateRasadnik(rasadnikDTO)](#M-WebApiPaulovnija-Controllers-RasadniciController-CreateRasadnik-WebApiPaulovnija-DTO-KreirajRasadnikDTO- 'WebApiPaulovnija.Controllers.RasadniciController.CreateRasadnik(WebApiPaulovnija.DTO.KreirajRasadnikDTO)')
  - [DeleteRasadnik(id)](#M-WebApiPaulovnija-Controllers-RasadniciController-DeleteRasadnik-System-Int32- 'WebApiPaulovnija.Controllers.RasadniciController.DeleteRasadnik(System.Int32)')
  - [GetRasadnici()](#M-WebApiPaulovnija-Controllers-RasadniciController-GetRasadnici 'WebApiPaulovnija.Controllers.RasadniciController.GetRasadnici')
  - [GetRasadnik(id)](#M-WebApiPaulovnija-Controllers-RasadniciController-GetRasadnik-System-Int32- 'WebApiPaulovnija.Controllers.RasadniciController.GetRasadnik(System.Int32)')
  - [UpdateRasadnik(id,rasadnikDTO)](#M-WebApiPaulovnija-Controllers-RasadniciController-UpdateRasadnik-System-Int32,WebApiPaulovnija-DTO-AzurirajRasadnikDTO- 'WebApiPaulovnija.Controllers.RasadniciController.UpdateRasadnik(System.Int32,WebApiPaulovnija.DTO.AzurirajRasadnikDTO)')
- [Rasadnik](#T-WebApiPaulovnija-Models-Rasadnik 'WebApiPaulovnija.Models.Rasadnik')
  - [Datum_otvaranja](#P-WebApiPaulovnija-Models-Rasadnik-Datum_otvaranja 'WebApiPaulovnija.Models.Rasadnik.Datum_otvaranja')
  - [ID_Rasadnika](#P-WebApiPaulovnija-Models-Rasadnik-ID_Rasadnika 'WebApiPaulovnija.Models.Rasadnik.ID_Rasadnika')
  - [Lokacija](#P-WebApiPaulovnija-Models-Rasadnik-Lokacija 'WebApiPaulovnija.Models.Rasadnik.Lokacija')
  - [Naziv](#P-WebApiPaulovnija-Models-Rasadnik-Naziv 'WebApiPaulovnija.Models.Rasadnik.Naziv')
  - [Povrsina](#P-WebApiPaulovnija-Models-Rasadnik-Povrsina 'WebApiPaulovnija.Models.Rasadnik.Povrsina')
  - [Sadnice](#P-WebApiPaulovnija-Models-Rasadnik-Sadnice 'WebApiPaulovnija.Models.Rasadnik.Sadnice')
- [RasadnikDTO](#T-RasadnikDTO 'RasadnikDTO')
  - [Datum_otvaranja](#P-RasadnikDTO-Datum_otvaranja 'RasadnikDTO.Datum_otvaranja')
  - [ID_Rasadnika](#P-RasadnikDTO-ID_Rasadnika 'RasadnikDTO.ID_Rasadnika')
  - [Lokacija](#P-RasadnikDTO-Lokacija 'RasadnikDTO.Lokacija')
  - [Naziv](#P-RasadnikDTO-Naziv 'RasadnikDTO.Naziv')
  - [Povrsina](#P-RasadnikDTO-Povrsina 'RasadnikDTO.Povrsina')
- [RasadnikService](#T-WebApiPaulovnija-Services-RasadnikService 'WebApiPaulovnija.Services.RasadnikService')
  - [#ctor(context)](#M-WebApiPaulovnija-Services-RasadnikService-#ctor-PaulovnijaContext- 'WebApiPaulovnija.Services.RasadnikService.#ctor(PaulovnijaContext)')
  - [CreateRasadnikAsync(rasadnikDTO)](#M-WebApiPaulovnija-Services-RasadnikService-CreateRasadnikAsync-WebApiPaulovnija-DTO-KreirajRasadnikDTO- 'WebApiPaulovnija.Services.RasadnikService.CreateRasadnikAsync(WebApiPaulovnija.DTO.KreirajRasadnikDTO)')
  - [DeleteRasadnikAsync(id)](#M-WebApiPaulovnija-Services-RasadnikService-DeleteRasadnikAsync-System-Int32- 'WebApiPaulovnija.Services.RasadnikService.DeleteRasadnikAsync(System.Int32)')
  - [GetAllRasadniciAsync()](#M-WebApiPaulovnija-Services-RasadnikService-GetAllRasadniciAsync 'WebApiPaulovnija.Services.RasadnikService.GetAllRasadniciAsync')
  - [GetRasadnikByIdAsync(id)](#M-WebApiPaulovnija-Services-RasadnikService-GetRasadnikByIdAsync-System-Int32- 'WebApiPaulovnija.Services.RasadnikService.GetRasadnikByIdAsync(System.Int32)')
  - [UpdateRasadnikAsync(rasadnikDTO)](#M-WebApiPaulovnija-Services-RasadnikService-UpdateRasadnikAsync-WebApiPaulovnija-DTO-AzurirajRasadnikDTO- 'WebApiPaulovnija.Services.RasadnikService.UpdateRasadnikAsync(WebApiPaulovnija.DTO.AzurirajRasadnikDTO)')
- [Sadnica](#T-WebApiPaulovnija-Models-Sadnica 'WebApiPaulovnija.Models.Sadnica')
  - [Datum_sadnje](#P-WebApiPaulovnija-Models-Sadnica-Datum_sadnje 'WebApiPaulovnija.Models.Sadnica.Datum_sadnje')
  - [ID_Rasadnika](#P-WebApiPaulovnija-Models-Sadnica-ID_Rasadnika 'WebApiPaulovnija.Models.Sadnica.ID_Rasadnika')
  - [ID_Sadnice](#P-WebApiPaulovnija-Models-Sadnica-ID_Sadnice 'WebApiPaulovnija.Models.Sadnica.ID_Sadnice')
  - [Rasadnik](#P-WebApiPaulovnija-Models-Sadnica-Rasadnik 'WebApiPaulovnija.Models.Sadnica.Rasadnik')
  - [Starost](#P-WebApiPaulovnija-Models-Sadnica-Starost 'WebApiPaulovnija.Models.Sadnica.Starost')
  - [Visina](#P-WebApiPaulovnija-Models-Sadnica-Visina 'WebApiPaulovnija.Models.Sadnica.Visina')
  - [Vrsta](#P-WebApiPaulovnija-Models-Sadnica-Vrsta 'WebApiPaulovnija.Models.Sadnica.Vrsta')
- [SadnicaDTO](#T-SadnicaDTO 'SadnicaDTO')
  - [Datum_sadnje](#P-SadnicaDTO-Datum_sadnje 'SadnicaDTO.Datum_sadnje')
  - [ID_Rasadnika](#P-SadnicaDTO-ID_Rasadnika 'SadnicaDTO.ID_Rasadnika')
  - [ID_Sadnice](#P-SadnicaDTO-ID_Sadnice 'SadnicaDTO.ID_Sadnice')
  - [Starost](#P-SadnicaDTO-Starost 'SadnicaDTO.Starost')
  - [Visina](#P-SadnicaDTO-Visina 'SadnicaDTO.Visina')
  - [Vrsta](#P-SadnicaDTO-Vrsta 'SadnicaDTO.Vrsta')
- [SadnicaService](#T-WebApiPaulovnija-Services-SadnicaService 'WebApiPaulovnija.Services.SadnicaService')
  - [#ctor(context)](#M-WebApiPaulovnija-Services-SadnicaService-#ctor-PaulovnijaContext- 'WebApiPaulovnija.Services.SadnicaService.#ctor(PaulovnijaContext)')
  - [AddAsync(sadnicaDTO)](#M-WebApiPaulovnija-Services-SadnicaService-AddAsync-WebApiPaulovnija-DTO-KreirajSadnicuDTO- 'WebApiPaulovnija.Services.SadnicaService.AddAsync(WebApiPaulovnija.DTO.KreirajSadnicuDTO)')
  - [DeleteAsync(id)](#M-WebApiPaulovnija-Services-SadnicaService-DeleteAsync-System-Int32- 'WebApiPaulovnija.Services.SadnicaService.DeleteAsync(System.Int32)')
  - [GetAllAsync()](#M-WebApiPaulovnija-Services-SadnicaService-GetAllAsync 'WebApiPaulovnija.Services.SadnicaService.GetAllAsync')
  - [GetByIdAsync(id)](#M-WebApiPaulovnija-Services-SadnicaService-GetByIdAsync-System-Int32- 'WebApiPaulovnija.Services.SadnicaService.GetByIdAsync(System.Int32)')
  - [UpdateAsync(sadnicaDTO)](#M-WebApiPaulovnija-Services-SadnicaService-UpdateAsync-WebApiPaulovnija-DTO-AzurirajSadnicuDTO- 'WebApiPaulovnija.Services.SadnicaService.UpdateAsync(WebApiPaulovnija.DTO.AzurirajSadnicuDTO)')
- [SadniceController](#T-WebApiPaulovnija-Controllers-SadniceController 'WebApiPaulovnija.Controllers.SadniceController')
  - [Create(sadnicaDTO)](#M-WebApiPaulovnija-Controllers-SadniceController-Create-WebApiPaulovnija-DTO-KreirajSadnicuDTO- 'WebApiPaulovnija.Controllers.SadniceController.Create(WebApiPaulovnija.DTO.KreirajSadnicuDTO)')
  - [Delete(id)](#M-WebApiPaulovnija-Controllers-SadniceController-Delete-System-Int32- 'WebApiPaulovnija.Controllers.SadniceController.Delete(System.Int32)')
  - [GetAll()](#M-WebApiPaulovnija-Controllers-SadniceController-GetAll 'WebApiPaulovnija.Controllers.SadniceController.GetAll')
  - [GetById(id)](#M-WebApiPaulovnija-Controllers-SadniceController-GetById-System-Int32- 'WebApiPaulovnija.Controllers.SadniceController.GetById(System.Int32)')
  - [Update(id,sadnicaDTO)](#M-WebApiPaulovnija-Controllers-SadniceController-Update-System-Int32,WebApiPaulovnija-DTO-AzurirajSadnicuDTO- 'WebApiPaulovnija.Controllers.SadniceController.Update(System.Int32,WebApiPaulovnija.DTO.AzurirajSadnicuDTO)')
- [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj')
  - [Godiste](#P-WebApiPaulovnija-Models-Stroj-Godiste 'WebApiPaulovnija.Models.Stroj.Godiste')
  - [ID_Radnika](#P-WebApiPaulovnija-Models-Stroj-ID_Radnika 'WebApiPaulovnija.Models.Stroj.ID_Radnika')
  - [ID_Stroja](#P-WebApiPaulovnija-Models-Stroj-ID_Stroja 'WebApiPaulovnija.Models.Stroj.ID_Stroja')
  - [Kapacitet_rezervoara](#P-WebApiPaulovnija-Models-Stroj-Kapacitet_rezervoara 'WebApiPaulovnija.Models.Stroj.Kapacitet_rezervoara')
  - [Marka](#P-WebApiPaulovnija-Models-Stroj-Marka 'WebApiPaulovnija.Models.Stroj.Marka')
  - [Model](#P-WebApiPaulovnija-Models-Stroj-Model 'WebApiPaulovnija.Models.Stroj.Model')
  - [Radnik](#P-WebApiPaulovnija-Models-Stroj-Radnik 'WebApiPaulovnija.Models.Stroj.Radnik')
  - [Tip](#P-WebApiPaulovnija-Models-Stroj-Tip 'WebApiPaulovnija.Models.Stroj.Tip')
- [StrojDTO](#T-StrojDTO 'StrojDTO')
  - [Godiste](#P-StrojDTO-Godiste 'StrojDTO.Godiste')
  - [ID_Radnika](#P-StrojDTO-ID_Radnika 'StrojDTO.ID_Radnika')
  - [ID_Stroja](#P-StrojDTO-ID_Stroja 'StrojDTO.ID_Stroja')
  - [Kapacitet_rezervoara](#P-StrojDTO-Kapacitet_rezervoara 'StrojDTO.Kapacitet_rezervoara')
  - [Marka](#P-StrojDTO-Marka 'StrojDTO.Marka')
  - [Model](#P-StrojDTO-Model 'StrojDTO.Model')
  - [Tip](#P-StrojDTO-Tip 'StrojDTO.Tip')
- [StrojService](#T-WebApiPaulovnija-Services-StrojService 'WebApiPaulovnija.Services.StrojService')
  - [#ctor(context)](#M-WebApiPaulovnija-Services-StrojService-#ctor-PaulovnijaContext- 'WebApiPaulovnija.Services.StrojService.#ctor(PaulovnijaContext)')
  - [AddAsync(stroj)](#M-WebApiPaulovnija-Services-StrojService-AddAsync-WebApiPaulovnija-Models-Stroj- 'WebApiPaulovnija.Services.StrojService.AddAsync(WebApiPaulovnija.Models.Stroj)')
  - [DeleteAsync(id)](#M-WebApiPaulovnija-Services-StrojService-DeleteAsync-System-Int32- 'WebApiPaulovnija.Services.StrojService.DeleteAsync(System.Int32)')
  - [GetAllAsync()](#M-WebApiPaulovnija-Services-StrojService-GetAllAsync 'WebApiPaulovnija.Services.StrojService.GetAllAsync')
  - [GetByIdAsync(id)](#M-WebApiPaulovnija-Services-StrojService-GetByIdAsync-System-Int32- 'WebApiPaulovnija.Services.StrojService.GetByIdAsync(System.Int32)')
  - [UpdateAsync(stroj)](#M-WebApiPaulovnija-Services-StrojService-UpdateAsync-WebApiPaulovnija-Models-Stroj- 'WebApiPaulovnija.Services.StrojService.UpdateAsync(WebApiPaulovnija.Models.Stroj)')
- [StrojeviController](#T-WebApiPaulovnija-Controllers-StrojeviController 'WebApiPaulovnija.Controllers.StrojeviController')
  - [Create(kreirajStrojDTO)](#M-WebApiPaulovnija-Controllers-StrojeviController-Create-WebApiPaulovnija-DTO-KreirajStrojDTO- 'WebApiPaulovnija.Controllers.StrojeviController.Create(WebApiPaulovnija.DTO.KreirajStrojDTO)')
  - [Delete(id)](#M-WebApiPaulovnija-Controllers-StrojeviController-Delete-System-Int32- 'WebApiPaulovnija.Controllers.StrojeviController.Delete(System.Int32)')
  - [GetAll()](#M-WebApiPaulovnija-Controllers-StrojeviController-GetAll 'WebApiPaulovnija.Controllers.StrojeviController.GetAll')
  - [GetById(id)](#M-WebApiPaulovnija-Controllers-StrojeviController-GetById-System-Int32- 'WebApiPaulovnija.Controllers.StrojeviController.GetById(System.Int32)')
  - [Update(id,azurirajStrojDTO)](#M-WebApiPaulovnija-Controllers-StrojeviController-Update-System-Int32,WebApiPaulovnija-DTO-AzurirajStrojDTO- 'WebApiPaulovnija.Controllers.StrojeviController.Update(System.Int32,WebApiPaulovnija.DTO.AzurirajStrojDTO)')
- [Zadatak](#T-WebApiPaulovnija-Models-Zadatak 'WebApiPaulovnija.Models.Zadatak')
  - [Datum_pocetka](#P-WebApiPaulovnija-Models-Zadatak-Datum_pocetka 'WebApiPaulovnija.Models.Zadatak.Datum_pocetka')
  - [Datum_zavrsetka](#P-WebApiPaulovnija-Models-Zadatak-Datum_zavrsetka 'WebApiPaulovnija.Models.Zadatak.Datum_zavrsetka')
  - [ID_Radnika](#P-WebApiPaulovnija-Models-Zadatak-ID_Radnika 'WebApiPaulovnija.Models.Zadatak.ID_Radnika')
  - [ID_Zadatka](#P-WebApiPaulovnija-Models-Zadatak-ID_Zadatka 'WebApiPaulovnija.Models.Zadatak.ID_Zadatka')
  - [Opis](#P-WebApiPaulovnija-Models-Zadatak-Opis 'WebApiPaulovnija.Models.Zadatak.Opis')
  - [Radnik](#P-WebApiPaulovnija-Models-Zadatak-Radnik 'WebApiPaulovnija.Models.Zadatak.Radnik')
  - [Status_Zadatka](#P-WebApiPaulovnija-Models-Zadatak-Status_Zadatka 'WebApiPaulovnija.Models.Zadatak.Status_Zadatka')
- [ZadatakController](#T-WebApiPaulovnija-Controllers-ZadatakController 'WebApiPaulovnija.Controllers.ZadatakController')
  - [Delete(id)](#M-WebApiPaulovnija-Controllers-ZadatakController-Delete-System-Int32- 'WebApiPaulovnija.Controllers.ZadatakController.Delete(System.Int32)')
  - [Get()](#M-WebApiPaulovnija-Controllers-ZadatakController-Get 'WebApiPaulovnija.Controllers.ZadatakController.Get')
  - [GetById(id)](#M-WebApiPaulovnija-Controllers-ZadatakController-GetById-System-Int32- 'WebApiPaulovnija.Controllers.ZadatakController.GetById(System.Int32)')
  - [Post(dto)](#M-WebApiPaulovnija-Controllers-ZadatakController-Post-KreirajZadatakDTO- 'WebApiPaulovnija.Controllers.ZadatakController.Post(KreirajZadatakDTO)')
  - [Put(id,dto)](#M-WebApiPaulovnija-Controllers-ZadatakController-Put-System-Int32,AzurirajZadatakDTO- 'WebApiPaulovnija.Controllers.ZadatakController.Put(System.Int32,AzurirajZadatakDTO)')
- [ZadatakDTO](#T-WebApiPaulovnija-DTO-ZadatakDTO 'WebApiPaulovnija.DTO.ZadatakDTO')
  - [Datum_pocetka](#P-WebApiPaulovnija-DTO-ZadatakDTO-Datum_pocetka 'WebApiPaulovnija.DTO.ZadatakDTO.Datum_pocetka')
  - [Datum_zavrsetka](#P-WebApiPaulovnija-DTO-ZadatakDTO-Datum_zavrsetka 'WebApiPaulovnija.DTO.ZadatakDTO.Datum_zavrsetka')
  - [ID_Radnika](#P-WebApiPaulovnija-DTO-ZadatakDTO-ID_Radnika 'WebApiPaulovnija.DTO.ZadatakDTO.ID_Radnika')
  - [ID_Zadatka](#P-WebApiPaulovnija-DTO-ZadatakDTO-ID_Zadatka 'WebApiPaulovnija.DTO.ZadatakDTO.ID_Zadatka')
  - [Opis](#P-WebApiPaulovnija-DTO-ZadatakDTO-Opis 'WebApiPaulovnija.DTO.ZadatakDTO.Opis')
  - [Status_Zadatka](#P-WebApiPaulovnija-DTO-ZadatakDTO-Status_Zadatka 'WebApiPaulovnija.DTO.ZadatakDTO.Status_Zadatka')
- [ZadatakService](#T--ZadatakService '.ZadatakService')
  - [#ctor(context,mapper)](#M-ZadatakService-#ctor-PaulovnijaContext,AutoMapper-IMapper- 'ZadatakService.#ctor(PaulovnijaContext,AutoMapper.IMapper)')
  - [CreateZadatakAsync(dto)](#M-ZadatakService-CreateZadatakAsync-KreirajZadatakDTO- 'ZadatakService.CreateZadatakAsync(KreirajZadatakDTO)')
  - [DeleteZadatakAsync(id)](#M-ZadatakService-DeleteZadatakAsync-System-Int32- 'ZadatakService.DeleteZadatakAsync(System.Int32)')
  - [GetAllZadaciAsync()](#M-ZadatakService-GetAllZadaciAsync 'ZadatakService.GetAllZadaciAsync')
  - [GetZadatakByIdAsync(id)](#M-ZadatakService-GetZadatakByIdAsync-System-Int32- 'ZadatakService.GetZadatakByIdAsync(System.Int32)')
  - [UpdateZadatakAsync(dto)](#M-ZadatakService-UpdateZadatakAsync-AzurirajZadatakDTO- 'ZadatakService.UpdateZadatakAsync(AzurirajZadatakDTO)')

<a name='T-WebApiPaulovnija-DTO-AzurirajRadnikaDTO'></a>
## AzurirajRadnikaDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za ažuriranje podataka o radniku.

<a name='P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Godine'></a>
### Godine `property`

##### Summary

Godine starosti radnika.

<a name='P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Ime'></a>
### Ime `property`

##### Summary

Ime radnika.

<a name='P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Plata'></a>
### Plata `property`

##### Summary

Plata radnika.

<a name='P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Pozicija'></a>
### Pozicija `property`

##### Summary

Pozicija na kojoj radnik radi.

<a name='P-WebApiPaulovnija-DTO-AzurirajRadnikaDTO-Prezime'></a>
### Prezime `property`

##### Summary

Prezime radnika.

<a name='T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO'></a>
## AzurirajRasadnikDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za ažuriranje informacija o rasadniku.

<a name='P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Datum_otvaranja'></a>
### Datum_otvaranja `property`

##### Summary

Datum otvaranja rasadnika.

<a name='P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Jedinstveni identifikator rasadnika.

<a name='P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Lokacija'></a>
### Lokacija `property`

##### Summary

Lokacija rasadnika, ne može biti duža od 100 znakova.

<a name='P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Naziv'></a>
### Naziv `property`

##### Summary

Naziv rasadnika, ne može biti duži od 100 znakova.

<a name='P-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-Povrsina'></a>
### Povrsina `property`

##### Summary

Površina rasadnika u kvadratnim metrima, mora biti pozitivna vrednost.

<a name='T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO'></a>
## AzurirajSadnicuDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za ažuriranje informacija o sadnici.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-DatumSadnje'></a>
### DatumSadnje `property`

##### Summary

Datum sadnje sadnice.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Identifikator rasadnika u kojem se sadnica nalazi.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-ID_Sadnice'></a>
### ID_Sadnice `property`

##### Summary

Jedinstveni identifikator sadnice.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Starost'></a>
### Starost `property`

##### Summary

Starost sadnice u godinama.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Visina'></a>
### Visina `property`

##### Summary

Visina sadnice u metrima.

<a name='P-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-Vrsta'></a>
### Vrsta `property`

##### Summary

Vrsta sadnice.

<a name='T-WebApiPaulovnija-DTO-AzurirajStrojDTO'></a>
## AzurirajStrojDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za ažuriranje informacija o stroju.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Godiste'></a>
### Godiste `property`

##### Summary

Godina proizvodnje stroja.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Identifikator radnika koji koristi stroj.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-ID_Stroja'></a>
### ID_Stroja `property`

##### Summary

Jedinstveni identifikator stroja.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Kapacitet_rezervoara'></a>
### Kapacitet_rezervoara `property`

##### Summary

Kapacitet rezervoara u litrima.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Marka'></a>
### Marka `property`

##### Summary

Marka stroja.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Model'></a>
### Model `property`

##### Summary

Model stroja.

<a name='P-WebApiPaulovnija-DTO-AzurirajStrojDTO-Tip'></a>
### Tip `property`

##### Summary

Tip stroja (npr. traktor, kombajn).

<a name='T--AzurirajZadatakDTO'></a>
## AzurirajZadatakDTO `type`

##### Namespace



<a name='P-AzurirajZadatakDTO-Datum_pocetka'></a>
### Datum_pocetka `property`

##### Summary

Datum kada zadatak počinje. Ovaj atribut je obavezan.

<a name='P-AzurirajZadatakDTO-Datum_zavrsetka'></a>
### Datum_zavrsetka `property`

##### Summary

Datum kada zadatak treba da bude završen. Ovaj atribut je obavezan.

<a name='P-AzurirajZadatakDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika kome je zadatak dodeljen. Ovaj atribut je obavezan.

<a name='P-AzurirajZadatakDTO-ID_Zadatka'></a>
### ID_Zadatka `property`

##### Summary

Jedinstveni identifikator zadatka koji se ažurira.

<a name='P-AzurirajZadatakDTO-Opis'></a>
### Opis `property`

##### Summary

Opis zadatka. Ovaj atribut je obavezan.

<a name='P-AzurirajZadatakDTO-Status_Zadatka'></a>
### Status_Zadatka `property`

##### Summary

Status zadatka (npr. u toku, završen). Ovaj atribut je obavezan.

<a name='T-WebApiPaulovnija-Services-IRadnikService'></a>
## IRadnikService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Interfejs za radne operacije vezane za radnike.

<a name='M-WebApiPaulovnija-Services-IRadnikService-CreateRadnikAsync-WebApiPaulovnija-Models-Radnik-'></a>
### CreateRadnikAsync(radnik) `method`

##### Summary

Kreira novog radnika asinhrono.

##### Returns

Instanca novog radnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Instanca radnika koja se kreira. |

<a name='M-WebApiPaulovnija-Services-IRadnikService-DeleteRadnikAsync-System-Int32-'></a>
### DeleteRadnikAsync(id) `method`

##### Summary

Briše radnika po ID-ju asinhrono.

##### Returns

True ako je brisanje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator radnika koji se briše. |

<a name='M-WebApiPaulovnija-Services-IRadnikService-GetAllRadniciAsync'></a>
### GetAllRadniciAsync() `method`

##### Summary

Dohvata sve radnike asinhrono.

##### Returns

Lista svih radnika.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-IRadnikService-GetRadnikByIdAsync-System-Int32-'></a>
### GetRadnikByIdAsync(id) `method`

##### Summary

Dohvata radnika po ID-ju asinhrono.

##### Returns

Instanca radnika ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator radnika. |

<a name='M-WebApiPaulovnija-Services-IRadnikService-UpdateRadnikAsync-WebApiPaulovnija-Models-Radnik-'></a>
### UpdateRadnikAsync(radnik) `method`

##### Summary

Ažurira podatke radnika asinhrono.

##### Returns

True ako je ažuriranje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Instanca radnika sa ažuriranim podacima. |

<a name='T-WebApiPaulovnija-Services-IRasadnikService'></a>
## IRasadnikService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Interfejs za radne operacije vezane za rasadnike.

<a name='M-WebApiPaulovnija-Services-IRasadnikService-CreateRasadnikAsync-WebApiPaulovnija-DTO-KreirajRasadnikDTO-'></a>
### CreateRasadnikAsync(rasadnikDTO) `method`

##### Summary

Kreira novi rasadnik asinhrono.

##### Returns

DTO objekat novog rasadnika.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rasadnikDTO | [WebApiPaulovnija.DTO.KreirajRasadnikDTO](#T-WebApiPaulovnija-DTO-KreirajRasadnikDTO 'WebApiPaulovnija.DTO.KreirajRasadnikDTO') | DTO objekat rasadnika koji se kreira. |

<a name='M-WebApiPaulovnija-Services-IRasadnikService-DeleteRasadnikAsync-System-Int32-'></a>
### DeleteRasadnikAsync(id) `method`

##### Summary

Briše rasadnik po ID-ju asinhrono.

##### Returns

True ako je brisanje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator rasadnika koji se briše. |

<a name='M-WebApiPaulovnija-Services-IRasadnikService-GetAllRasadniciAsync'></a>
### GetAllRasadniciAsync() `method`

##### Summary

Dohvata sve rasadnike asinhrono.

##### Returns

Lista DTO objekata svih rasadnika.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-IRasadnikService-GetRasadnikByIdAsync-System-Int32-'></a>
### GetRasadnikByIdAsync(id) `method`

##### Summary

Dohvata rasadnik po ID-ju asinhrono.

##### Returns

DTO objekat rasadnika ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator rasadnika. |

<a name='M-WebApiPaulovnija-Services-IRasadnikService-UpdateRasadnikAsync-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-'></a>
### UpdateRasadnikAsync(rasadnik) `method`

##### Summary

Ažurira podatke rasadnika asinhrono.

##### Returns

True ako je ažuriranje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rasadnik | [WebApiPaulovnija.DTO.AzurirajRasadnikDTO](#T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO') | DTO objekat rasadnika sa ažuriranim podacima. |

<a name='T-WebApiPaulovnija-Services-ISadnicaService'></a>
## ISadnicaService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Interfejs za radne operacije vezane za sadnice.

<a name='M-WebApiPaulovnija-Services-ISadnicaService-AddAsync-WebApiPaulovnija-DTO-KreirajSadnicuDTO-'></a>
### AddAsync(sadnicaDTO) `method`

##### Summary

Dodaje novu sadnicu asinhrono.

##### Returns

DTO objekat novog sadnice.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sadnicaDTO | [WebApiPaulovnija.DTO.KreirajSadnicuDTO](#T-WebApiPaulovnija-DTO-KreirajSadnicuDTO 'WebApiPaulovnija.DTO.KreirajSadnicuDTO') | DTO objekat sadnice koja se dodaje. |

<a name='M-WebApiPaulovnija-Services-ISadnicaService-DeleteAsync-System-Int32-'></a>
### DeleteAsync(id) `method`

##### Summary

Briše sadnicu po ID-ju asinhrono.

##### Returns

True ako je brisanje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator sadnice koja se briše. |

<a name='M-WebApiPaulovnija-Services-ISadnicaService-GetAllAsync'></a>
### GetAllAsync() `method`

##### Summary

Dohvata sve sadnice asinhrono.

##### Returns

Lista DTO objekata svih sadnica.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-ISadnicaService-GetByIdAsync-System-Int32-'></a>
### GetByIdAsync(id) `method`

##### Summary

Dohvata sadnicu po ID-ju asinhrono.

##### Returns

DTO objekat sadnice ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator sadnice. |

<a name='M-WebApiPaulovnija-Services-ISadnicaService-UpdateAsync-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-'></a>
### UpdateAsync(sadnicaDTO) `method`

##### Summary

Ažurira podatke sadnice asinhrono.

##### Returns

True ako je ažuriranje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sadnicaDTO | [WebApiPaulovnija.DTO.AzurirajSadnicuDTO](#T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO') | DTO objekat sadnice sa ažuriranim podacima. |

<a name='T-WebApiPaulovnija-Services-IStrojService'></a>
## IStrojService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Interfejs za radne operacije vezane za strojeve.

<a name='M-WebApiPaulovnija-Services-IStrojService-AddAsync-WebApiPaulovnija-Models-Stroj-'></a>
### AddAsync(stroj) `method`

##### Summary

Dodaje novi stroj asinhrono.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stroj | [WebApiPaulovnija.Models.Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') | Instanca stroja koja se dodaje. |

<a name='M-WebApiPaulovnija-Services-IStrojService-DeleteAsync-System-Int32-'></a>
### DeleteAsync(id) `method`

##### Summary

Briše stroj po ID-ju asinhrono.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator stroja koji se briše. |

<a name='M-WebApiPaulovnija-Services-IStrojService-GetAllAsync'></a>
### GetAllAsync() `method`

##### Summary

Dohvata sve strojeve asinhrono.

##### Returns

Lista svih strojeva.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-IStrojService-GetByIdAsync-System-Int32-'></a>
### GetByIdAsync(id) `method`

##### Summary

Dohvata stroj po ID-ju asinhrono.

##### Returns

Instanca stroja ili null ako nije pronađena.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator stroja. |

<a name='M-WebApiPaulovnija-Services-IStrojService-UpdateAsync-WebApiPaulovnija-Models-Stroj-'></a>
### UpdateAsync(stroj) `method`

##### Summary

Ažurira podatke stroja asinhrono.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stroj | [WebApiPaulovnija.Models.Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') | Instanca stroja sa ažuriranim podacima. |

<a name='T--IZadatakService'></a>
## IZadatakService `type`

##### Namespace



<a name='M-IZadatakService-CreateZadatakAsync-KreirajZadatakDTO-'></a>
### CreateZadatakAsync(dto) `method`

##### Summary

Kreira novi zadatak asinhrono.

##### Returns

DTO objekat novog zadatka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [KreirajZadatakDTO](#T-KreirajZadatakDTO 'KreirajZadatakDTO') | DTO objekat sa podacima za kreiranje zadatka. |

<a name='M-IZadatakService-DeleteZadatakAsync-System-Int32-'></a>
### DeleteZadatakAsync(id) `method`

##### Summary

Briše zadatak po ID-ju asinhrono.

##### Returns

True ako je brisanje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator zadatka koji se briše. |

<a name='M-IZadatakService-GetAllZadaciAsync'></a>
### GetAllZadaciAsync() `method`

##### Summary

Dohvata sve zadatke asinhrono.

##### Returns

Lista DTO objekata svih zadataka.

##### Parameters

This method has no parameters.

<a name='M-IZadatakService-GetZadatakByIdAsync-System-Int32-'></a>
### GetZadatakByIdAsync(id) `method`

##### Summary

Dohvata zadatak po ID-ju asinhrono.

##### Returns

DTO objekat zadatka ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Jedinstveni identifikator zadatka. |

<a name='M-IZadatakService-UpdateZadatakAsync-AzurirajZadatakDTO-'></a>
### UpdateZadatakAsync(dto) `method`

##### Summary

Ažurira postojeći zadatak asinhrono.

##### Returns

True ako je ažuriranje uspešno, inače False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [AzurirajZadatakDTO](#T-AzurirajZadatakDTO 'AzurirajZadatakDTO') | DTO objekat sa ažuriranim podacima zadatka. |

<a name='T-WebApiPaulovnija-DTO-KreirajRadnikaDTO'></a>
## KreirajRadnikaDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za kreiranje novog radnika.

<a name='P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Godine'></a>
### Godine `property`

##### Summary

Godine starosti radnika. Ovo polje je obavezno.

<a name='P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Ime'></a>
### Ime `property`

##### Summary

Ime radnika. Ovo polje je obavezno.

<a name='P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Plata'></a>
### Plata `property`

##### Summary

Plata radnika. Ovo polje je obavezno.

<a name='P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Pozicija'></a>
### Pozicija `property`

##### Summary

Pozicija radnika na poslu. Ovo polje je obavezno.

<a name='P-WebApiPaulovnija-DTO-KreirajRadnikaDTO-Prezime'></a>
### Prezime `property`

##### Summary

Prezime radnika. Ovo polje je obavezno.

<a name='T-WebApiPaulovnija-DTO-KreirajRasadnikDTO'></a>
## KreirajRasadnikDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za kreiranje novog rasadnika.

<a name='P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Datum_otvaranja'></a>
### Datum_otvaranja `property`

##### Summary

Datum otvaranja rasadnika.

<a name='P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Lokacija'></a>
### Lokacija `property`

##### Summary

Lokacija rasadnika. Ne može biti duža od 100 znakova.

<a name='P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Naziv'></a>
### Naziv `property`

##### Summary

Naziv rasadnika. Ne može biti duži od 100 znakova.

<a name='P-WebApiPaulovnija-DTO-KreirajRasadnikDTO-Povrsina'></a>
### Povrsina `property`

##### Summary

Površina rasadnika u kvadratnim metrima. Mora biti pozitivna vrednost.

<a name='T-WebApiPaulovnija-DTO-KreirajSadnicuDTO'></a>
## KreirajSadnicuDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za kreiranje nove sadnice.

<a name='P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Datum_sadnje'></a>
### Datum_sadnje `property`

##### Summary

Datum sadnje sadnice.

<a name='P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Identifikator rasadnika u kojem se sadnica nalazi.

<a name='P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Starost'></a>
### Starost `property`

##### Summary

Starost sadnice u godinama.

<a name='P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Visina'></a>
### Visina `property`

##### Summary

Visina sadnice u metrima.

<a name='P-WebApiPaulovnija-DTO-KreirajSadnicuDTO-Vrsta'></a>
### Vrsta `property`

##### Summary

Vrsta sadnice (npr. drvo, biljka).

<a name='T-WebApiPaulovnija-DTO-KreirajStrojDTO'></a>
## KreirajStrojDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa za kreiranje novog stroja.

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-Godiste'></a>
### Godiste `property`

##### Summary

Godina proizvodnje stroja.

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Identifikator radnika koji koristi stroj.

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-Kapacitet_rezervoara'></a>
### Kapacitet_rezervoara `property`

##### Summary

Kapacitet rezervoara u litrima.

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-Marka'></a>
### Marka `property`

##### Summary

Marka stroja (npr. John Deere, Case IH).

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-Model'></a>
### Model `property`

##### Summary

Model stroja (npr. 5055E).

<a name='P-WebApiPaulovnija-DTO-KreirajStrojDTO-Tip'></a>
### Tip `property`

##### Summary

Tip stroja (npr. traktor, kombajn).

<a name='T--KreirajZadatakDTO'></a>
## KreirajZadatakDTO `type`

##### Namespace



<a name='P-KreirajZadatakDTO-Datum_pocetka'></a>
### Datum_pocetka `property`

##### Summary

Datum kada zadatak počinje. Ovo polje je obavezno.

<a name='P-KreirajZadatakDTO-Datum_zavrsetka'></a>
### Datum_zavrsetka `property`

##### Summary

Datum kada zadatak treba da bude završen. Ovo polje je obavezno.

<a name='P-KreirajZadatakDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika kome je zadatak dodeljen. Ovo polje je obavezno.

<a name='P-KreirajZadatakDTO-Opis'></a>
### Opis `property`

##### Summary

Opis zadatka. Ovo polje je obavezno.

<a name='P-KreirajZadatakDTO-Status_Zadatka'></a>
### Status_Zadatka `property`

##### Summary

Status zadatka (npr. u toku, završen). Ovo polje je obavezno.

<a name='T-WebApiPaulovnija-Mapping-MappingProfile'></a>
## MappingProfile `type`

##### Namespace

WebApiPaulovnija.Mapping

##### Summary

Konfiguracija mapiranja između modela i DTO klasa.

<a name='M-WebApiPaulovnija-Mapping-MappingProfile-#ctor'></a>
### #ctor() `constructor`

##### Summary

Inicijalizuje novu instancu [MappingProfile](#T-WebApiPaulovnija-Mapping-MappingProfile 'WebApiPaulovnija.Mapping.MappingProfile') klase.

##### Parameters

This constructor has no parameters.

<a name='T--PaulovnijaContext'></a>
## PaulovnijaContext `type`

##### Namespace



<a name='M-PaulovnijaContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{PaulovnijaContext}-'></a>
### #ctor(options) `constructor`

##### Summary

Inicijalizira novu instancu [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{PaulovnijaContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{PaulovnijaContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{PaulovnijaContext}') | Opcije koje će koristiti [DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext'). |

<a name='P-PaulovnijaContext-Radnici'></a>
### Radnici `property`

##### Summary

Dobiva ili postavlja kolekciju radnika (Radnici).

<a name='P-PaulovnijaContext-Rasadnik'></a>
### Rasadnik `property`

##### Summary

Dobiva ili postavlja kolekciju rasadnika (Rasadnik).

<a name='P-PaulovnijaContext-Sadnice'></a>
### Sadnice `property`

##### Summary

Dobiva ili postavlja kolekciju sadnica (Sadnice).

<a name='P-PaulovnijaContext-Strojevi'></a>
### Strojevi `property`

##### Summary

Dobiva ili postavlja kolekciju strojeva (Strojevi).

<a name='P-PaulovnijaContext-Zadaci'></a>
### Zadaci `property`

##### Summary

Dobiva ili postavlja kolekciju zadataka (Zadaci).

<a name='M-PaulovnijaContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating(modelBuilder) `method`

##### Summary

Konfigurira model prilikom kreiranja konteksta.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelBuilder | [Microsoft.EntityFrameworkCore.ModelBuilder](#T-Microsoft-EntityFrameworkCore-ModelBuilder 'Microsoft.EntityFrameworkCore.ModelBuilder') | Graditelj koji se koristi za konstruiranje modela za kontekst. |

<a name='T-WebApiPaulovnija-Controllers-Models-RadniciList'></a>
## RadniciList `type`

##### Namespace

WebApiPaulovnija.Controllers.Models

##### Summary

Klasa koja predstavlja listu radnika.

<a name='P-WebApiPaulovnija-Controllers-Models-RadniciList-ListaRadnika'></a>
### ListaRadnika `property`

##### Summary

Lista radnika.

<a name='T-WebApiPaulovnija-Models-Radnik'></a>
## Radnik `type`

##### Namespace

WebApiPaulovnija.Models

##### Summary

Klasa koja predstavlja radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-Godine'></a>
### Godine `property`

##### Summary

Godine starosti radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-Ime'></a>
### Ime `property`

##### Summary

Ime radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-Plata'></a>
### Plata `property`

##### Summary

Plata radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-Pozicija'></a>
### Pozicija `property`

##### Summary

Pozicija radnika na poslu.

<a name='P-WebApiPaulovnija-Models-Radnik-Prezime'></a>
### Prezime `property`

##### Summary

Prezime radnika.

<a name='P-WebApiPaulovnija-Models-Radnik-Strojevi'></a>
### Strojevi `property`

##### Summary

Lista strojeva kojima upravlja radnik.

<a name='P-WebApiPaulovnija-Models-Radnik-Zadaci'></a>
### Zadaci `property`

##### Summary

Lista zadataka dodeljenih radniku.

<a name='T-WebApiPaulovnija-Controllers-RadnikController'></a>
## RadnikController `type`

##### Namespace

WebApiPaulovnija.Controllers

<a name='M-WebApiPaulovnija-Controllers-RadnikController-Delete-System-Int32-'></a>
### Delete(id) `method`

##### Summary

Briše radnika iz baze podataka.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika koji se briše. |

<a name='M-WebApiPaulovnija-Controllers-RadnikController-Get'></a>
### Get() `method`

##### Summary

Vraća sve radnike iz baze podataka.

##### Returns

Lista radnika u formatu RadnikDTO.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Controllers-RadnikController-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Vraća radnika po ID-u.

##### Returns

Radnik sa traženim ID-em u formatu RadnikDTO.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika. |

<a name='M-WebApiPaulovnija-Controllers-RadnikController-Post-WebApiPaulovnija-DTO-KreirajRadnikaDTO-'></a>
### Post(dto) `method`

##### Summary

Dodaje novog radnika u bazu podataka.

##### Returns

Status rezultata unosa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [WebApiPaulovnija.DTO.KreirajRadnikaDTO](#T-WebApiPaulovnija-DTO-KreirajRadnikaDTO 'WebApiPaulovnija.DTO.KreirajRadnikaDTO') | DTO objekt radnika koji se dodaje. |

<a name='M-WebApiPaulovnija-Controllers-RadnikController-Put-System-Int32,WebApiPaulovnija-DTO-AzurirajRadnikaDTO-'></a>
### Put(id,dto) `method`

##### Summary

Ažurira radnika u bazi podataka.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika koji se ažurira. |
| dto | [WebApiPaulovnija.DTO.AzurirajRadnikaDTO](#T-WebApiPaulovnija-DTO-AzurirajRadnikaDTO 'WebApiPaulovnija.DTO.AzurirajRadnikaDTO') | DTO objekt sa novim podacima radnika. |

<a name='T-RadnikDTO'></a>
## RadnikDTO `type`

##### Namespace



##### Summary

DTO klasa koja predstavlja radnika.

<a name='P-RadnikDTO-Godine'></a>
### Godine `property`

##### Summary

Godine starosti radnika.

<a name='P-RadnikDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika.

<a name='P-RadnikDTO-Ime'></a>
### Ime `property`

##### Summary

Ime radnika.

<a name='P-RadnikDTO-Plata'></a>
### Plata `property`

##### Summary

Plata radnika.

<a name='P-RadnikDTO-Pozicija'></a>
### Pozicija `property`

##### Summary

Pozicija radnika na poslu.

<a name='P-RadnikDTO-Prezime'></a>
### Prezime `property`

##### Summary

Prezime radnika.

<a name='T-WebApiPaulovnija-Service-RadnikService'></a>
## RadnikService `type`

##### Namespace

WebApiPaulovnija.Service

##### Summary

Implementacija servisa za upravljanje radnicima.

<a name='M-WebApiPaulovnija-Service-RadnikService-#ctor-PaulovnijaContext-'></a>
### #ctor(context) `constructor`

##### Summary

Inicijalizira novu instancu [RadnikService](#T-WebApiPaulovnija-Service-RadnikService 'WebApiPaulovnija.Service.RadnikService') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') | Kontekst baze podataka za pristup podacima o radnicima. |

<a name='M-WebApiPaulovnija-Service-RadnikService-CreateRadnik-WebApiPaulovnija-Models-Radnik-'></a>
### CreateRadnik(radnik) `method`

##### Summary

Dodaje novog radnika u bazu podataka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Objekt radnika koji se dodaje. |

<a name='M-WebApiPaulovnija-Service-RadnikService-CreateRadnikAsync-WebApiPaulovnija-Models-Radnik-'></a>
### CreateRadnikAsync(radnik) `method`

##### Summary

Asinkrono dodaje novog radnika u bazu podataka.

##### Returns

Vraća asinkroni rezultat operacije dodavanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Objekt radnika koji se dodaje. |

<a name='M-WebApiPaulovnija-Service-RadnikService-DeleteRadnik-WebApiPaulovnija-Models-Radnik-'></a>
### DeleteRadnik(radnik) `method`

##### Summary

Briše radnika iz baze podataka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Objekt radnika koji se briše. |

<a name='M-WebApiPaulovnija-Service-RadnikService-DeleteRadnikAsync-System-Int32-'></a>
### DeleteRadnikAsync(id) `method`

##### Summary

Asinkrono briše radnika iz baze podataka na temelju ID-a.

##### Returns

True ako je radnik uspješno obrisan, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika koji se briše. |

<a name='M-WebApiPaulovnija-Service-RadnikService-GetAllRadnici'></a>
### GetAllRadnici() `method`

##### Summary

Vraća sve radnike iz baze podataka.

##### Returns

Lista svih radnika.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Service-RadnikService-GetAllRadniciAsync'></a>
### GetAllRadniciAsync() `method`

##### Summary

Asinkrono vraća sve radnike iz baze podataka.

##### Returns

Lista svih radnika.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Service-RadnikService-GetRadnikById-System-Int32-'></a>
### GetRadnikById(id) `method`

##### Summary

Vraća radnika na temelju ID-a.

##### Returns

Radnik ako je pronađen, inače null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika koji se želi pretražiti. |

<a name='M-WebApiPaulovnija-Service-RadnikService-GetRadnikByIdAsync-System-Int32-'></a>
### GetRadnikByIdAsync(id) `method`

##### Summary

Asinkrono vraća radnika na temelju ID-a.

##### Returns

Radnik ako je pronađen, inače null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID radnika koji se želi pretražiti. |

<a name='M-WebApiPaulovnija-Service-RadnikService-UpdateRadnik-WebApiPaulovnija-Models-Radnik-'></a>
### UpdateRadnik(radnik) `method`

##### Summary

Ažurira postojećeg radnika u bazi podataka.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Objekt radnika koji sadrži ažurirane podatke. |

<a name='M-WebApiPaulovnija-Service-RadnikService-UpdateRadnikAsync-WebApiPaulovnija-Models-Radnik-'></a>
### UpdateRadnikAsync(radnik) `method`

##### Summary

Asinkrono ažurira postojećeg radnika u bazi podataka.

##### Returns

True ako je ažuriranje uspješno, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| radnik | [WebApiPaulovnija.Models.Radnik](#T-WebApiPaulovnija-Models-Radnik 'WebApiPaulovnija.Models.Radnik') | Objekt radnika koji sadrži ažurirane podatke. |

<a name='T-WebApiPaulovnija-Controllers-RasadniciController'></a>
## RasadniciController `type`

##### Namespace

WebApiPaulovnija.Controllers

<a name='M-WebApiPaulovnija-Controllers-RasadniciController-CreateRasadnik-WebApiPaulovnija-DTO-KreirajRasadnikDTO-'></a>
### CreateRasadnik(rasadnikDTO) `method`

##### Summary

Dodaje novog rasadnika u bazu podataka.

##### Returns

Status rezultata unosa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rasadnikDTO | [WebApiPaulovnija.DTO.KreirajRasadnikDTO](#T-WebApiPaulovnija-DTO-KreirajRasadnikDTO 'WebApiPaulovnija.DTO.KreirajRasadnikDTO') | DTO objekt rasadnika koji se dodaje. |

<a name='M-WebApiPaulovnija-Controllers-RasadniciController-DeleteRasadnik-System-Int32-'></a>
### DeleteRasadnik(id) `method`

##### Summary

Briše rasadnik iz baze podataka.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID rasadnika koji se briše. |

<a name='M-WebApiPaulovnija-Controllers-RasadniciController-GetRasadnici'></a>
### GetRasadnici() `method`

##### Summary

Vraća sve rasadnike iz baze podataka.

##### Returns

Lista rasadnika.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Controllers-RasadniciController-GetRasadnik-System-Int32-'></a>
### GetRasadnik(id) `method`

##### Summary

Vraća rasadnik po ID-u.

##### Returns

Rasadnik sa traženim ID-em.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID rasadnika. |

<a name='M-WebApiPaulovnija-Controllers-RasadniciController-UpdateRasadnik-System-Int32,WebApiPaulovnija-DTO-AzurirajRasadnikDTO-'></a>
### UpdateRasadnik(id,rasadnikDTO) `method`

##### Summary

Ažurira postojeći rasadnik u bazi podataka.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID rasadnika koji se ažurira. |
| rasadnikDTO | [WebApiPaulovnija.DTO.AzurirajRasadnikDTO](#T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO') | DTO objekt sa novim podacima rasadnika. |

<a name='T-WebApiPaulovnija-Models-Rasadnik'></a>
## Rasadnik `type`

##### Namespace

WebApiPaulovnija.Models

##### Summary

Klasa koja predstavlja rasadnik.

<a name='P-WebApiPaulovnija-Models-Rasadnik-Datum_otvaranja'></a>
### Datum_otvaranja `property`

##### Summary

Datum otvaranja rasadnika.

<a name='P-WebApiPaulovnija-Models-Rasadnik-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Jedinstveni identifikator rasadnika.

<a name='P-WebApiPaulovnija-Models-Rasadnik-Lokacija'></a>
### Lokacija `property`

##### Summary

Lokacija rasadnika.

<a name='P-WebApiPaulovnija-Models-Rasadnik-Naziv'></a>
### Naziv `property`

##### Summary

Naziv rasadnika.

<a name='P-WebApiPaulovnija-Models-Rasadnik-Povrsina'></a>
### Povrsina `property`

##### Summary

Površina rasadnika u hektarima.

<a name='P-WebApiPaulovnija-Models-Rasadnik-Sadnice'></a>
### Sadnice `property`

##### Summary

Lista sadnica u rasadniku.

<a name='T-RasadnikDTO'></a>
## RasadnikDTO `type`

##### Namespace



##### Summary

DTO klasa koja predstavlja rasadnik.

<a name='P-RasadnikDTO-Datum_otvaranja'></a>
### Datum_otvaranja `property`

##### Summary

Datum otvaranja rasadnika.

<a name='P-RasadnikDTO-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Jedinstveni identifikator rasadnika.

<a name='P-RasadnikDTO-Lokacija'></a>
### Lokacija `property`

##### Summary

Lokacija rasadnika.

<a name='P-RasadnikDTO-Naziv'></a>
### Naziv `property`

##### Summary

Naziv rasadnika.

<a name='P-RasadnikDTO-Povrsina'></a>
### Povrsina `property`

##### Summary

Površina rasadnika u kvadratnim metrima.

<a name='T-WebApiPaulovnija-Services-RasadnikService'></a>
## RasadnikService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Servisna klasa za upravljanje rasadnicima (Rasadnik).

<a name='M-WebApiPaulovnija-Services-RasadnikService-#ctor-PaulovnijaContext-'></a>
### #ctor(context) `constructor`

##### Summary

Inicijalizira novu instancu [RasadnikService](#T-WebApiPaulovnija-Services-RasadnikService 'WebApiPaulovnija.Services.RasadnikService') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') | Kontext baze podataka koji se koristi za interakciju s bazom podataka. |

<a name='M-WebApiPaulovnija-Services-RasadnikService-CreateRasadnikAsync-WebApiPaulovnija-DTO-KreirajRasadnikDTO-'></a>
### CreateRasadnikAsync(rasadnikDTO) `method`

##### Summary

Stvara novi rasadnik iz navedenog [KreirajRasadnikDTO](#T-WebApiPaulovnija-DTO-KreirajRasadnikDTO 'WebApiPaulovnija.DTO.KreirajRasadnikDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži novi stvoreni [RasadnikDTO](#T-RasadnikDTO 'RasadnikDTO').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rasadnikDTO | [WebApiPaulovnija.DTO.KreirajRasadnikDTO](#T-WebApiPaulovnija-DTO-KreirajRasadnikDTO 'WebApiPaulovnija.DTO.KreirajRasadnikDTO') | Podaci o novom rasadniku. |

<a name='M-WebApiPaulovnija-Services-RasadnikService-DeleteRasadnikAsync-System-Int32-'></a>
### DeleteRasadnikAsync(id) `method`

##### Summary

Briše rasadnik prema njegovom ID-u.

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je brisanje uspješno, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID rasadnika koji treba izbrisati. |

<a name='M-WebApiPaulovnija-Services-RasadnikService-GetAllRasadniciAsync'></a>
### GetAllRasadniciAsync() `method`

##### Summary

Dohvaća sve rasadnike kao listu [RasadnikDTO](#T-RasadnikDTO 'RasadnikDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju [RasadnikDTO](#T-RasadnikDTO 'RasadnikDTO').

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-RasadnikService-GetRasadnikByIdAsync-System-Int32-'></a>
### GetRasadnikByIdAsync(id) `method`

##### Summary

Dohvaća rasadnik prema njegovom ID-u.

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži [RasadnikDTO](#T-RasadnikDTO 'RasadnikDTO') za određeni rasadnik, ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID rasadnika koji treba dohvatiti. |

<a name='M-WebApiPaulovnija-Services-RasadnikService-UpdateRasadnikAsync-WebApiPaulovnija-DTO-AzurirajRasadnikDTO-'></a>
### UpdateRasadnikAsync(rasadnikDTO) `method`

##### Summary

Ažurira rasadnik na temelju navedenog [AzurirajRasadnikDTO](#T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je ažuriranje uspješno, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rasadnikDTO | [WebApiPaulovnija.DTO.AzurirajRasadnikDTO](#T-WebApiPaulovnija-DTO-AzurirajRasadnikDTO 'WebApiPaulovnija.DTO.AzurirajRasadnikDTO') | Podaci za ažuriranje rasadnika. |

<a name='T-WebApiPaulovnija-Models-Sadnica'></a>
## Sadnica `type`

##### Namespace

WebApiPaulovnija.Models

##### Summary

Klasa koja predstavlja sadnicu.

<a name='P-WebApiPaulovnija-Models-Sadnica-Datum_sadnje'></a>
### Datum_sadnje `property`

##### Summary

Datum sadnje sadnice.

<a name='P-WebApiPaulovnija-Models-Sadnica-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Jedinstveni identifikator rasadnika kojem pripada sadnica.

<a name='P-WebApiPaulovnija-Models-Sadnica-ID_Sadnice'></a>
### ID_Sadnice `property`

##### Summary

Jedinstveni identifikator sadnice.

<a name='P-WebApiPaulovnija-Models-Sadnica-Rasadnik'></a>
### Rasadnik `property`

##### Summary

Referenca na rasadnik kojem sadnica pripada.

<a name='P-WebApiPaulovnija-Models-Sadnica-Starost'></a>
### Starost `property`

##### Summary

Starost sadnice u godinama.

<a name='P-WebApiPaulovnija-Models-Sadnica-Visina'></a>
### Visina `property`

##### Summary

Visina sadnice u metrima.

<a name='P-WebApiPaulovnija-Models-Sadnica-Vrsta'></a>
### Vrsta `property`

##### Summary

Vrsta sadnice.

<a name='T-SadnicaDTO'></a>
## SadnicaDTO `type`

##### Namespace



##### Summary

DTO klasa koja predstavlja sadnicu.

<a name='P-SadnicaDTO-Datum_sadnje'></a>
### Datum_sadnje `property`

##### Summary

Datum sadnje sadnice.

<a name='P-SadnicaDTO-ID_Rasadnika'></a>
### ID_Rasadnika `property`

##### Summary

Identifikator rasadnika u kojem se sadnica nalazi.

<a name='P-SadnicaDTO-ID_Sadnice'></a>
### ID_Sadnice `property`

##### Summary

Jedinstveni identifikator sadnice.

<a name='P-SadnicaDTO-Starost'></a>
### Starost `property`

##### Summary

Starost sadnice u godinama.

<a name='P-SadnicaDTO-Visina'></a>
### Visina `property`

##### Summary

Visina sadnice u metrima.

<a name='P-SadnicaDTO-Vrsta'></a>
### Vrsta `property`

##### Summary

Vrsta sadnice (npr. drvo, biljka).

<a name='T-WebApiPaulovnija-Services-SadnicaService'></a>
## SadnicaService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Servisna klasa za upravljanje sadnicama (Sadnica).

<a name='M-WebApiPaulovnija-Services-SadnicaService-#ctor-PaulovnijaContext-'></a>
### #ctor(context) `constructor`

##### Summary

Inicijalizira novu instancu [SadnicaService](#T-WebApiPaulovnija-Services-SadnicaService 'WebApiPaulovnija.Services.SadnicaService') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') | Kontext baze podataka koji se koristi za interakciju s bazom podataka. |

<a name='M-WebApiPaulovnija-Services-SadnicaService-AddAsync-WebApiPaulovnija-DTO-KreirajSadnicuDTO-'></a>
### AddAsync(sadnicaDTO) `method`

##### Summary

Dodaje novu sadnicu iz navedenog [KreirajSadnicuDTO](#T-WebApiPaulovnija-DTO-KreirajSadnicuDTO 'WebApiPaulovnija.DTO.KreirajSadnicuDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži novu stvorenu [SadnicaDTO](#T-SadnicaDTO 'SadnicaDTO').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sadnicaDTO | [WebApiPaulovnija.DTO.KreirajSadnicuDTO](#T-WebApiPaulovnija-DTO-KreirajSadnicuDTO 'WebApiPaulovnija.DTO.KreirajSadnicuDTO') | Podaci o novoj sadnici. |

<a name='M-WebApiPaulovnija-Services-SadnicaService-DeleteAsync-System-Int32-'></a>
### DeleteAsync(id) `method`

##### Summary

Briše sadnicu prema njenom ID-u.

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je brisanje uspješno, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID sadnice koja se treba izbrisati. |

<a name='M-WebApiPaulovnija-Services-SadnicaService-GetAllAsync'></a>
### GetAllAsync() `method`

##### Summary

Dohvaća sve sadnice kao listu [SadnicaDTO](#T-SadnicaDTO 'SadnicaDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju [SadnicaDTO](#T-SadnicaDTO 'SadnicaDTO').

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-SadnicaService-GetByIdAsync-System-Int32-'></a>
### GetByIdAsync(id) `method`

##### Summary

Dohvaća sadnicu prema njenom ID-u.

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži [SadnicaDTO](#T-SadnicaDTO 'SadnicaDTO') za određenu sadnicu, ili null ako nije pronađena.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID sadnice koja se treba dohvatiti. |

<a name='M-WebApiPaulovnija-Services-SadnicaService-UpdateAsync-WebApiPaulovnija-DTO-AzurirajSadnicuDTO-'></a>
### UpdateAsync(sadnicaDTO) `method`

##### Summary

Ažurira sadnicu na temelju navedenog [AzurirajSadnicuDTO](#T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je ažuriranje uspješno, inače false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sadnicaDTO | [WebApiPaulovnija.DTO.AzurirajSadnicuDTO](#T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO') | Podaci za ažuriranje sadnice. |

<a name='T-WebApiPaulovnija-Controllers-SadniceController'></a>
## SadniceController `type`

##### Namespace

WebApiPaulovnija.Controllers

<a name='M-WebApiPaulovnija-Controllers-SadniceController-Create-WebApiPaulovnija-DTO-KreirajSadnicuDTO-'></a>
### Create(sadnicaDTO) `method`

##### Summary

Dodaje novu sadnicu u bazu podataka.

##### Returns

Status rezultata unosa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sadnicaDTO | [WebApiPaulovnija.DTO.KreirajSadnicuDTO](#T-WebApiPaulovnija-DTO-KreirajSadnicuDTO 'WebApiPaulovnija.DTO.KreirajSadnicuDTO') | DTO objekt sadnice koji se dodaje. |

<a name='M-WebApiPaulovnija-Controllers-SadniceController-Delete-System-Int32-'></a>
### Delete(id) `method`

##### Summary

Briše sadnicu iz baze podataka.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID sadnice koji se briše. |

<a name='M-WebApiPaulovnija-Controllers-SadniceController-GetAll'></a>
### GetAll() `method`

##### Summary

Vraća sve sadnice iz baze podataka.

##### Returns

Lista sadnica.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Controllers-SadniceController-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Vraća sadnicu po ID-u.

##### Returns

Sadnica sa traženim ID-em.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID sadnice. |

<a name='M-WebApiPaulovnija-Controllers-SadniceController-Update-System-Int32,WebApiPaulovnija-DTO-AzurirajSadnicuDTO-'></a>
### Update(id,sadnicaDTO) `method`

##### Summary

Ažurira postojeću sadnicu u bazi podataka.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID sadnice koji se ažurira. |
| sadnicaDTO | [WebApiPaulovnija.DTO.AzurirajSadnicuDTO](#T-WebApiPaulovnija-DTO-AzurirajSadnicuDTO 'WebApiPaulovnija.DTO.AzurirajSadnicuDTO') | DTO objekt sa novim podacima sadnice. |

<a name='T-WebApiPaulovnija-Models-Stroj'></a>
## Stroj `type`

##### Namespace

WebApiPaulovnija.Models

##### Summary

Klasa koja predstavlja stroj.

<a name='P-WebApiPaulovnija-Models-Stroj-Godiste'></a>
### Godiste `property`

##### Summary

Godina proizvodnje stroja.

<a name='P-WebApiPaulovnija-Models-Stroj-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika koji upravlja strojem.

<a name='P-WebApiPaulovnija-Models-Stroj-ID_Stroja'></a>
### ID_Stroja `property`

##### Summary

Jedinstveni identifikator stroja.

<a name='P-WebApiPaulovnija-Models-Stroj-Kapacitet_rezervoara'></a>
### Kapacitet_rezervoara `property`

##### Summary

Kapacitet rezervoara stroja u litrima.

<a name='P-WebApiPaulovnija-Models-Stroj-Marka'></a>
### Marka `property`

##### Summary

Marka stroja.

<a name='P-WebApiPaulovnija-Models-Stroj-Model'></a>
### Model `property`

##### Summary

Model stroja.

<a name='P-WebApiPaulovnija-Models-Stroj-Radnik'></a>
### Radnik `property`

##### Summary

Referenca na radnika koji upravlja strojem.

<a name='P-WebApiPaulovnija-Models-Stroj-Tip'></a>
### Tip `property`

##### Summary

Tip stroja.

<a name='T-StrojDTO'></a>
## StrojDTO `type`

##### Namespace



##### Summary

DTO klasa koja predstavlja stroj.

<a name='P-StrojDTO-Godiste'></a>
### Godiste `property`

##### Summary

Godina proizvodnje stroja.

<a name='P-StrojDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika koji je dodeljen ovom stroju.

<a name='P-StrojDTO-ID_Stroja'></a>
### ID_Stroja `property`

##### Summary

Jedinstveni identifikator stroja.

<a name='P-StrojDTO-Kapacitet_rezervoara'></a>
### Kapacitet_rezervoara `property`

##### Summary

Kapacitet rezervoara u litrama.

<a name='P-StrojDTO-Marka'></a>
### Marka `property`

##### Summary

Marka stroja (npr. John Deere, Case).

<a name='P-StrojDTO-Model'></a>
### Model `property`

##### Summary

Model stroja (npr. 1234, XYZ).

<a name='P-StrojDTO-Tip'></a>
### Tip `property`

##### Summary

Tip stroja (npr. traktorski, berba).

<a name='T-WebApiPaulovnija-Services-StrojService'></a>
## StrojService `type`

##### Namespace

WebApiPaulovnija.Services

##### Summary

Servisna klasa za upravljanje strojevima (Stroj).

<a name='M-WebApiPaulovnija-Services-StrojService-#ctor-PaulovnijaContext-'></a>
### #ctor(context) `constructor`

##### Summary

Inicijalizira novu instancu [StrojService](#T-WebApiPaulovnija-Services-StrojService 'WebApiPaulovnija.Services.StrojService') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') | Kontext baze podataka koji se koristi za interakciju s bazom podataka. |

<a name='M-WebApiPaulovnija-Services-StrojService-AddAsync-WebApiPaulovnija-Models-Stroj-'></a>
### AddAsync(stroj) `method`

##### Summary

Dodaje novi stroj u bazu podataka.

##### Returns

Task koji predstavlja asinkronu operaciju.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stroj | [WebApiPaulovnija.Models.Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') | Instanca [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') koja se dodaje. |

<a name='M-WebApiPaulovnija-Services-StrojService-DeleteAsync-System-Int32-'></a>
### DeleteAsync(id) `method`

##### Summary

Briše stroj prema njegovom ID-u iz baze podataka.

##### Returns

Task koji predstavlja asinkronu operaciju.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID stroja koji se treba izbrisati. |

<a name='M-WebApiPaulovnija-Services-StrojService-GetAllAsync'></a>
### GetAllAsync() `method`

##### Summary

Dohvaća sve strojeve kao listu [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj').

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj').

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Services-StrojService-GetByIdAsync-System-Int32-'></a>
### GetByIdAsync(id) `method`

##### Summary

Dohvaća stroj prema njegovom ID-u.

##### Returns

Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') za određeni stroj, ili null ako nije pronađen.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID stroja koji se treba dohvatiti. |

<a name='M-WebApiPaulovnija-Services-StrojService-UpdateAsync-WebApiPaulovnija-Models-Stroj-'></a>
### UpdateAsync(stroj) `method`

##### Summary

Ažurira postojeći stroj u bazi podataka.

##### Returns

Task koji predstavlja asinkronu operaciju.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stroj | [WebApiPaulovnija.Models.Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') | Instanca [Stroj](#T-WebApiPaulovnija-Models-Stroj 'WebApiPaulovnija.Models.Stroj') koja se ažurira. |

<a name='T-WebApiPaulovnija-Controllers-StrojeviController'></a>
## StrojeviController `type`

##### Namespace

WebApiPaulovnija.Controllers

<a name='M-WebApiPaulovnija-Controllers-StrojeviController-Create-WebApiPaulovnija-DTO-KreirajStrojDTO-'></a>
### Create(kreirajStrojDTO) `method`

##### Summary

Dodaje novi stroj u bazu podataka.

##### Returns

Status rezultata unosa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| kreirajStrojDTO | [WebApiPaulovnija.DTO.KreirajStrojDTO](#T-WebApiPaulovnija-DTO-KreirajStrojDTO 'WebApiPaulovnija.DTO.KreirajStrojDTO') | DTO objekt za novi stroj. |

<a name='M-WebApiPaulovnija-Controllers-StrojeviController-Delete-System-Int32-'></a>
### Delete(id) `method`

##### Summary

Briše stroj iz baze podataka.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID stroja koji se briše. |

<a name='M-WebApiPaulovnija-Controllers-StrojeviController-GetAll'></a>
### GetAll() `method`

##### Summary

Vraća sve strojeve iz baze podataka.

##### Returns

Lista strojeva.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Controllers-StrojeviController-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Vraća stroj po ID-u.

##### Returns

Stroj sa traženim ID-em.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID stroja. |

<a name='M-WebApiPaulovnija-Controllers-StrojeviController-Update-System-Int32,WebApiPaulovnija-DTO-AzurirajStrojDTO-'></a>
### Update(id,azurirajStrojDTO) `method`

##### Summary

Ažurira postojeći stroj u bazi podataka.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID stroja koji se ažurira. |
| azurirajStrojDTO | [WebApiPaulovnija.DTO.AzurirajStrojDTO](#T-WebApiPaulovnija-DTO-AzurirajStrojDTO 'WebApiPaulovnija.DTO.AzurirajStrojDTO') | DTO objekt sa novim podacima stroja. |

<a name='T-WebApiPaulovnija-Models-Zadatak'></a>
## Zadatak `type`

##### Namespace

WebApiPaulovnija.Models

##### Summary

Klasa koja predstavlja zadatak.

<a name='P-WebApiPaulovnija-Models-Zadatak-Datum_pocetka'></a>
### Datum_pocetka `property`

##### Summary

Datum početka zadatka.

<a name='P-WebApiPaulovnija-Models-Zadatak-Datum_zavrsetka'></a>
### Datum_zavrsetka `property`

##### Summary

Datum završetka zadatka.

<a name='P-WebApiPaulovnija-Models-Zadatak-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika koji je dodeljen zadatku.

<a name='P-WebApiPaulovnija-Models-Zadatak-ID_Zadatka'></a>
### ID_Zadatka `property`

##### Summary

Jedinstveni identifikator zadatka.

<a name='P-WebApiPaulovnija-Models-Zadatak-Opis'></a>
### Opis `property`

##### Summary

Opis zadatka.

<a name='P-WebApiPaulovnija-Models-Zadatak-Radnik'></a>
### Radnik `property`

##### Summary

Referenca na radnika koji je dodeljen zadatku.

<a name='P-WebApiPaulovnija-Models-Zadatak-Status_Zadatka'></a>
### Status_Zadatka `property`

##### Summary

Status zadatka (npr. "u toku", "završen").

<a name='T-WebApiPaulovnija-Controllers-ZadatakController'></a>
## ZadatakController `type`

##### Namespace

WebApiPaulovnija.Controllers

<a name='M-WebApiPaulovnija-Controllers-ZadatakController-Delete-System-Int32-'></a>
### Delete(id) `method`

##### Summary

Briše zadatak iz baze podataka.

##### Returns

Status brisanja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID zadatka koji se briše. |

<a name='M-WebApiPaulovnija-Controllers-ZadatakController-Get'></a>
### Get() `method`

##### Summary

Vraća sve zadatke iz baze podataka.

##### Returns

Lista zadataka.

##### Parameters

This method has no parameters.

<a name='M-WebApiPaulovnija-Controllers-ZadatakController-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Vraća zadatak po ID-u.

##### Returns

Zadatak sa traženim ID-em.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID zadatka. |

<a name='M-WebApiPaulovnija-Controllers-ZadatakController-Post-KreirajZadatakDTO-'></a>
### Post(dto) `method`

##### Summary

Dodaje novi zadatak u bazu podataka.

##### Returns

Status rezultata unosa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [KreirajZadatakDTO](#T-KreirajZadatakDTO 'KreirajZadatakDTO') | DTO objekt za novi zadatak. |

<a name='M-WebApiPaulovnija-Controllers-ZadatakController-Put-System-Int32,AzurirajZadatakDTO-'></a>
### Put(id,dto) `method`

##### Summary

Ažurira postojeći zadatak u bazi podataka.

##### Returns

Status ažuriranja.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID zadatka koji se ažurira. |
| dto | [AzurirajZadatakDTO](#T-AzurirajZadatakDTO 'AzurirajZadatakDTO') | DTO objekt sa novim podacima zadatka. |

<a name='T-WebApiPaulovnija-DTO-ZadatakDTO'></a>
## ZadatakDTO `type`

##### Namespace

WebApiPaulovnija.DTO

##### Summary

DTO klasa koja predstavlja zadatak.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-Datum_pocetka'></a>
### Datum_pocetka `property`

##### Summary

Datum kada zadatak počinje.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-Datum_zavrsetka'></a>
### Datum_zavrsetka `property`

##### Summary

Datum kada zadatak treba da bude završen.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-ID_Radnika'></a>
### ID_Radnika `property`

##### Summary

Jedinstveni identifikator radnika koji je dodeljen zadatku.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-ID_Zadatka'></a>
### ID_Zadatka `property`

##### Summary

Jedinstveni identifikator zadatka.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-Opis'></a>
### Opis `property`

##### Summary

Opis zadatka.

<a name='P-WebApiPaulovnija-DTO-ZadatakDTO-Status_Zadatka'></a>
### Status_Zadatka `property`

##### Summary

Status zadatka (npr. u toku, završen).

<a name='T--ZadatakService'></a>
## ZadatakService `type`

##### Namespace



<a name='M-ZadatakService-#ctor-PaulovnijaContext,AutoMapper-IMapper-'></a>
### #ctor(context,mapper) `constructor`

##### Summary

Inicijalizira novu instancu [ZadatakService](#T-ZadatakService 'ZadatakService') klase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [PaulovnijaContext](#T-PaulovnijaContext 'PaulovnijaContext') | Kontekst baze podataka za pristup bazi. |
| mapper | [AutoMapper.IMapper](#T-AutoMapper-IMapper 'AutoMapper.IMapper') | Instanca AutoMapper-a za mapiranje između entiteta i DTO-a. |

<a name='M-ZadatakService-CreateZadatakAsync-KreirajZadatakDTO-'></a>
### CreateZadatakAsync(dto) `method`

##### Summary

Kreira novi zadatak (Zadatak).

##### Returns

Kreirani zadatak kao [ZadatakDTO](#T-WebApiPaulovnija-DTO-ZadatakDTO 'WebApiPaulovnija.DTO.ZadatakDTO').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [KreirajZadatakDTO](#T-KreirajZadatakDTO 'KreirajZadatakDTO') | DTO koji sadrži podatke o zadatku. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Baca se kada navedeni radnik ne postoji. |

<a name='M-ZadatakService-DeleteZadatakAsync-System-Int32-'></a>
### DeleteZadatakAsync(id) `method`

##### Summary

Briše zadatak (Zadatak) prema njegovom ID-u.

##### Returns

True ako je zadatak uspješno obrisan; inače, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID zadatka koji treba obrisati. |

<a name='M-ZadatakService-GetAllZadaciAsync'></a>
### GetAllZadaciAsync() `method`

##### Summary

Dohvaća sve zadatke (Zadaci).

##### Returns

Lista zadataka kao [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1').

##### Parameters

This method has no parameters.

<a name='M-ZadatakService-GetZadatakByIdAsync-System-Int32-'></a>
### GetZadatakByIdAsync(id) `method`

##### Summary

Dohvaća zadatak (Zadatak) prema njegovom ID-u.

##### Returns

Zadatak kao [ZadatakDTO](#T-WebApiPaulovnija-DTO-ZadatakDTO 'WebApiPaulovnija.DTO.ZadatakDTO').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | ID zadatka koji treba dohvatiti. |

<a name='M-ZadatakService-UpdateZadatakAsync-AzurirajZadatakDTO-'></a>
### UpdateZadatakAsync(dto) `method`

##### Summary

Ažurira postojeći zadatak (Zadatak).

##### Returns

True ako je ažuriranje uspješno; inače, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dto | [AzurirajZadatakDTO](#T-AzurirajZadatakDTO 'AzurirajZadatakDTO') | DTO koji sadrži ažurirane podatke o zadatku. |
