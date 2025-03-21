/**
 * Tournament Manager
 * 
 * Database - всички отбори, участващи в турнирите на Pro Evolution Soccer 2013 BUL MOD 7
 * В различните масиви се съхряняват данните за отборите (техните имена)
 * 
 * Четирите различни масива са за четири различни турнира:
 * UEFA Europe League, UEFA Euro France, FIFA World Cup Russia и UEFA Champions League  
 */

namespace TournamentManager
{
    internal class Database
    {

        //Отборите от световното първенство по футбол в Русия през 2018 година.
        public readonly string[] fifaWorldCupTeams =
        {
            "Austria","Belgium","Croatia","Sweetzerland",
            "Denmanrk","England","Sweeden","France",
            "Germany","Greece","Hungary","Portugal",
            "Italy","Netherland","Poland","Spain",
            "Egypt","Niger","South Africa","Marocco",
            "Argentina","Canada","Mexico","USA",
            "Brasil","Columbia","Chili","Australia",
            "Chinese","Japan","South Korea","Ecuador"
        };

        //Отборите от европейското първенство по футбол във Франция през 2022 година.
        public readonly string[] uefaEuroTeams =
        {
            "Austria","Belgium","Croatia","Sweetzerland",
            "Denmanrk","England","Sweeden","France",
            "Germany","Greece","Hungary","Portugal",
            "Italy","Netherland","Poland","Spain"
        };

        //Отборите от шампионска лига
        public readonly string[] championsLeagueTeams =
        {
            "Arsenal","Chelsea","Manchester City","Liverpool",
            "PSG","Uventus","Roma","Napoli",
            "Barcelona","Atletico de Madrid","Basel","Real Madrid",
            "Ajax","Manchester United","Totenham Hotspurs","Inter",
            "Lazio","Milan","Fiorentina","Sevilia",
            "Valencia","Atletic Bilbao","Baier Leverkusen","Baier Munich",
            "Borussia Dortmund","Stuttgard","Wolfsburg","Newcastle United",
            "Olimpic de Marsillie","Genoa","Malaga","Everton"
        };

        //Отборите от лига европа
        public readonly string[] uefaEuropeLeagueTeams =
        {
            "Anderlect","Slavia Praha","PSV Eindhoven","Basel",
            "Legia Warshaw","Partizan Belgrade","Slovan Bratislava","Vardar",
            "Fenerbahce","Victoria Pilzen","Apoel Nikosia","Ausburg",
            "Eintracht Frankfurt","Maintz 05","Hanover 96","Stuttgard",
            "Wolksburg","Levante","Malaga","Sevilia",
            "Atletic Bilbao","Real Sociadat","Fiorentina","Lazio",
            "Newcastle United","Udineze","Genoa","Lil",
            "Olimpic Marsilie","South Hempton","Sunderland","Stoke City"
        };

    }
}