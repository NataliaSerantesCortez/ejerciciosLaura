extends CharacterBody2D

const GRAVITY = 980.0
const JUMP_VELOCITY = -350.0
var juego_iniciado = false

func _physics_process(delta: float) -> void:
	# Add the gravity.
	if juego_iniciado:
		velocity.y += GRAVITY*delta

	# Handle jump.
	if Input.is_action_just_pressed("ui_accept"):
		if not juego_iniciado:
				juego_iniciado = true
		velocity.y = JUMP_VELOCITY

	move_and_slide()
func _ready():
	add_to_group("marciano")
