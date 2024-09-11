//
//  Game.swift
//  DartsEngine
//
//  Created by Mathew Padley on 28/08/2024.
//

import Foundation

class Game {
    //let gameType: GameType
    private var players: [String] = []
    private let maxPlayers = 6
    
    init(gameType: GameType) {
        //self.gameType = gameType
    }
    
    func addPlayer(name: String) throws {
        guard players.count < maxPlayers else {
            throw GameError.tooManyPlayers
        }
        players.append(name)
    }
    
    func getPlayers() -> [String] {
        return players
    }
    
    enum GameError: Error {
        case tooManyPlayers
    }
}
