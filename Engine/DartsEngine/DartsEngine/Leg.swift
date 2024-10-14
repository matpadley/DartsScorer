//
//  Leg.swift
//  DartsEngine.Tests
//
//  Created by Mathew Padley on 11/09/2024.
//

import Foundation

enum LegError: Error {
    case invalidScore
}

class Leg
{
    init ()
    {
        
    }
    
    var Score: Int = 0
    var Throws: [Int] = []
    
    func addScore(score: DartScore, multiplier: ThrowMultiplier) throws
    {
        guard Throws.count < 3 else {
            throw LegError.invalidScore
        }
        
        let throwScore = score.rawValue * multiplier.rawValue
        
        Throws.append(throwScore)
        Score += throwScore;
    }
    
    func addScore(score: Int) throws
    {
        guard Throws.count < 3 else {
            throw LegError.invalidScore
        }
        
        Throws.append(score)
        Score += score;
    }
}
