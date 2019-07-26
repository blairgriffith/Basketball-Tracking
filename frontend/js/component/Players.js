export default function Players(teamlist){
    return `
    <h1>Players</h1>
    <div class='team-by-id'>
    <div class='all-teams'>
        ${teamlist.map(team => {
        return `
                <div class='team-image'>
                    <img src="${team.imageURL}">
                </div>
                
                <div class='players-by-id'> 
                    ${team.players.map(player =>{
                        return `
                        <div class='child-by-id'>
                            <img src="${player.imageURL}">
                            <p>${player.name}</p>
                        </div>
                    
                    `
                })
            .join("")}
                </div>
        `
        })
    .join("")}
            </div>
    </div>
    `
}