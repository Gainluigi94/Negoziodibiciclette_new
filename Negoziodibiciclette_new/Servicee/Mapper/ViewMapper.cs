using AutoMapper;
using Models;
using Models.Classi;

using Servicee.Request.Acquisti;
using Servicee.Request.Bici;
using Servicee.Request.Cartadicredito;
using Servicee.Request.Indirizzo;
using Servicee.Request.Persona;
using Servicee.Request.Regione;
using Servicee.Request.Utente;
using Servicee.Response.Bici;
using Servicee.Response.Cartadicredito;
using Servicee.Response.Indirizzo;
using Servicee.Response.Persona;
using Servicee.Response.Regione;
using Servicee.Response.Utente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Mapper
{
    public class ViewMapper:Profile
    {


        public ViewMapper()
        {
            #region Acquisti
            CreateMap<Acquisti, AddAcquisti>();
            CreateMap< AddAcquisti,Acquisti>();
            CreateMap<Acquisti, DeleteAcquisti>();
            CreateMap<DeleteAcquisti,Acquisti>();
          
            CreateMap<Acquisti, GetAllAcquisti>();
            CreateMap<GetAllAcquisti, Acquisti>();
            #endregion

            #region Indirizzi
            CreateMap<Indirizzo, AddIndirizzo>();
            CreateMap<AddIndirizzo,Indirizzo>();
            CreateMap<Indirizzo, DeleteIndirizzo>();
            CreateMap<DeleteIndirizzo, Indirizzo>();
            CreateMap<Indirizzo, EditIndirizzo>();
            CreateMap<EditIndirizzo, Indirizzo>();
            CreateMap<Indirizzo, IndirizzoResponse>();
            CreateMap<IndirizzoResponse, Indirizzo>();

            #endregion

            #region Cartadicredito
            CreateMap<Cartadicredito, CartadicreditoRequest>();
            CreateMap<CartadicreditoRequest, Cartadicredito>();
            CreateMap<Cartadicredito, DeleteCartadicredito>();
            CreateMap<DeleteCartadicredito, Cartadicredito>();
            CreateMap<Cartadicredito, CartadicreditoResponse>();
            CreateMap<CartadicreditoResponse, Cartadicredito>();

            #endregion

            #region Persona
            CreateMap<Persona, AddPersona>();
            CreateMap<AddPersona, Persona>();
            CreateMap<Persona, DeletePersona>();
            CreateMap<DeletePersona, Persona>();
            CreateMap<Persona, PersonaResponse>();
            CreateMap<PersonaResponse, Persona>();
            CreateMap<Persona,EditPersona>();
            CreateMap<EditPersona, Persona>();

            #endregion

            #region Regione
            CreateMap<Regione, AddRegione>();
            CreateMap<AddRegione, Regione>();
            CreateMap<Regione, DeleteRegione>();
            CreateMap<DeleteRegione, Regione>();
            CreateMap<Regione, EditRegione>();
            CreateMap<EditRegione, Regione>();
            CreateMap<Regione, RegioneResponse>();
            CreateMap<RegioneResponse, Regione>();
            #endregion

            #region Bici
            CreateMap<Bici, AddBici>();
            CreateMap<AddBici, Bici>();
            CreateMap<Bici, DeleteBici>();
            CreateMap<DeleteBici, Bici>();
            CreateMap<Bici, EditBici>();
            CreateMap<EditBici, Bici>();
            CreateMap<Bici, GetAllBici>();
            CreateMap<GetAllBici, Bici>();

            #endregion

            #region Utente 
            CreateMap<Utente, AddUtente>();
            CreateMap<AddUtente, Utente>();
            CreateMap<Utente, DeleteUtente>();
            CreateMap<DeleteUtente, Utente>();
            CreateMap<Utente, EditPassword>();
            CreateMap<EditPassword, Utente>();
            CreateMap<Utente, UtenteResponse>();
            CreateMap<UtenteResponse, Utente>();
            #endregion





        }
    }
}
