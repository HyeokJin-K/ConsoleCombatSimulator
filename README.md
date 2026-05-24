# ConsoleCombatSimulator
Practice for build basic combat system project

 * 프로젝트 설명 *

   몬스터와 플레이어 객체가 누구 한 명이 쓰러질 때 까지 서로 번갈아가면서 공격하는 간단한 Console 기반 전투 시뮬레이터.

  - Console Text Only 기본 턴제 전투 시스템 연습.
  - C# 기초적인 인터페이스 및 클래스 설계.
  - Character 클래스를 상속받은 Enemy, Player 객체.
  - Character 기본 스탯 (Name, MaxHp, AttackPower, Speed) 및 행동(Attack, Die)


#5/24. 시뮬레이션 시작 -> 스피드가 빠른 개체가 먼저 공격 -> 느린 개체가 공격 -> 번갈아가면서 차례대로 공격을 반복 -> 어느 한 쪽의 currentHp가 0이 될 경우 Die 메서드 실행 후 시뮬레이션 종료.
//콘솔 환경에서 텍스트 출력으로만 구현하는게 은근 귀찮고 어렵다... 무엇보다 텍스트만 있어서 재미가 없다..
