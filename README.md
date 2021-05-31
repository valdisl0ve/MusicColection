# MusicColection


use local



db.musicColection.insertOne({  executor:"Blablarism",      album:"unknown",            country:"unknown" , date:"09.09.2012", lenght:"3:28", song:"Saule discours",   style:"unknown" })
db.musicColection.insertOne({  executor:"The Soft Moon",   album:"Deeper",             country:"USA" ,     date:"11.11.2050", lenght:"3:56", song:"Far",              style:"shoegaze" })
db.musicColection.insertOne({  executor:"Crystal Castles", album:"Crystal Castles II", country:"Canada" ,  date:"09.09.2012", lenght:"3:28", song:"Empathy",          style:"experimental" })
db.musicColection.insertOne({  executor:"Crystal Castles", album:"Crystal Castles II", country:"Canada" ,  date:"09.09.2012", lenght:"4:28", song:"Vietnam",          style:"experimental" })




db.musicColection.find()

db.musicColection.drop()
