export default function Players(playerlist){
    return `
    <h1>Players</h1>
    <ul>
        ${playerlist.map(players => {
        return `
            <playerL>
                <p>${players.playerId}</p>
                <img src="${players.imageURL}">
            </playerL>
            `
        })}
    
    `
}