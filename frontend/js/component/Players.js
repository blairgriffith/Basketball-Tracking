export default function Players(playerlist){
    return `
    <h1>Players</h1>
    <ul>
        ${playerlist.map(player => {
        return `
            <li>
                <p>${player.playerId}</p>
                <img src="${player.ImageURL}">
            </li>
            `
        })}
    
    `
}